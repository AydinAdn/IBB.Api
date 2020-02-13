using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using IBB.Api.Events;
using IBB.Api.Models;

namespace IBB.Api
{
    public class AracKonumCacheService
    {
        private readonly IIbbClient ibbClient;
        private readonly Dictionary<string, Dictionary<DateTime, AracKonumuResponse>> cache;
        private readonly TimeSpan timeToWaitBeetweenUpdates;

        public AracKonumCacheService() : this(null)
        {
        }

        public AracKonumCacheService(IIbbClient client) : this(client, TimeSpan.FromSeconds(60))
        {
        }

        public AracKonumCacheService(IIbbClient client, TimeSpan timeBetweenUpdates)
        {
            this.ibbClient = client ?? new IbbClient();
            this.cache = new Dictionary<string, Dictionary<DateTime, AracKonumuResponse>>();
            this.timeToWaitBeetweenUpdates = timeBetweenUpdates;
        }

        public event EventHandler<AracKonumUpdatedEventArgs> OnAracKonumUpdate;

        public async Task BeginTracking(CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested) break;

                IEnumerable<AracKonumuResponse> aracKonumResults = await this.ibbClient.GetAracKonumlariAsync();

                List<AracKonumuResponse> guncellenenAracKonumlari = new List<AracKonumuResponse>();
                foreach (AracKonumuResponse aracKonumBilgisi in aracKonumResults)
                {
                    // Filter out invalid data
                    if (aracKonumBilgisi.Plaka == null) continue;

                    // Populate missing entries
                    if (!this.cache.ContainsKey(aracKonumBilgisi.Plaka))
                    {
                        this.cache.Add(aracKonumBilgisi.Plaka, new Dictionary<DateTime, AracKonumuResponse>());
                    }

                    // Values haven't been updated, skip.
                    if (this.cache[aracKonumBilgisi.Plaka].ContainsKey(aracKonumBilgisi.Saat)) continue;

                    // Ordering records by most recently added data, this is to prevent data received 
                    // out of order from appearing as an update.
                    KeyValuePair<DateTime, AracKonumuResponse>[] tempCollection = this.cache[aracKonumBilgisi.Plaka].OrderByDescending(k => k.Key).ToArray();

                    if (tempCollection.Any())
                    {
                        AracKonumuResponse temp = tempCollection.First().Value;
                        if (temp.Saat > aracKonumBilgisi.Saat)
                        {
                            continue;
                        }
                    } // Done preventing data being received out of order

                    // Clear previous location data and add the new one in its place.
                    // By doing so we're managing the amount of memory the library is using.
                    this.cache[aracKonumBilgisi.Plaka].Clear();
                    this.cache[aracKonumBilgisi.Plaka].Add(aracKonumBilgisi.Saat, aracKonumBilgisi);

                    // Add the item to the collection of items that will be included in the batched event arguments.
                    guncellenenAracKonumlari.Add(aracKonumBilgisi);
                }


                if (guncellenenAracKonumlari.Any())
                {
                    this.OnAracKonumUpdate?.Invoke(this, new AracKonumUpdatedEventArgs(guncellenenAracKonumlari));
                    guncellenenAracKonumlari.Clear();
                }

                await Task.Delay(this.timeToWaitBeetweenUpdates, token);
            }
        }
    }
}