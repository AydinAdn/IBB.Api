using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using IBB.Api.Events;
using IBB.Api.Models;

namespace IBB.Api
{
    public class VehicleLocationCacheService
    {
        private readonly IIbbClient ibbClient;
        private readonly Dictionary<string, Dictionary<DateTime, VehicleLocationResponse>> cache;
        private readonly TimeSpan delayToWaitBeetweenUpdates;

        public VehicleLocationCacheService() : this(null)
        {
        }

        public VehicleLocationCacheService(IIbbClient client) : this(client, TimeSpan.FromSeconds(60))
        {
        }

        public VehicleLocationCacheService(IIbbClient client, TimeSpan delayBetweenUpdates)
        {
            this.ibbClient = client ?? new IbbClient();
            this.cache = new Dictionary<string, Dictionary<DateTime, VehicleLocationResponse>>();
            this.delayToWaitBeetweenUpdates = delayBetweenUpdates;
        }

        public event EventHandler<VehiclesLocationUpdatedEventArgs> OnVehicleLocationUpdate;

        public async Task BeginTracking(CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested) break;

                IEnumerable<VehicleLocationResponse> vehicleLocationsResponse = await this.ibbClient.GetVehicleLocationsAsync();

                List<VehicleLocationResponse> updatedVehicleLocations = new List<VehicleLocationResponse>();
                foreach (VehicleLocationResponse vehicleLocationData in vehicleLocationsResponse)
                {
                    // Filter out invalid data
                    if (vehicleLocationData.NumberPlate == null) continue;

                    // Populate missing entries
                    if (!this.cache.ContainsKey(vehicleLocationData.NumberPlate))
                    {
                        this.cache.Add(vehicleLocationData.NumberPlate, new Dictionary<DateTime, VehicleLocationResponse>());
                    }

                    // Values haven't been updated, skip.
                    if (this.cache[vehicleLocationData.NumberPlate].ContainsKey(vehicleLocationData.LocationTimeStamp)) continue;

                    // Ordering records by most recently added data, this is to prevent data received 
                    // out of order from appearing as an update.
                    KeyValuePair<DateTime, VehicleLocationResponse>[] tempCollection = this.cache[vehicleLocationData.NumberPlate].OrderByDescending(k => k.Key).ToArray();

                    if (tempCollection.Any())
                    {
                        VehicleLocationResponse temp = tempCollection.First().Value;
                        if (temp.LocationTimeStamp > vehicleLocationData.LocationTimeStamp)
                        {
                            continue;
                        }
                    } // Done preventing data being received out of order

                    // Clear previous location data and add the new one in its place.
                    // By doing so we're managing the amount of memory the library is using.
                    this.cache[vehicleLocationData.NumberPlate].Clear();
                    this.cache[vehicleLocationData.NumberPlate].Add(vehicleLocationData.LocationTimeStamp, vehicleLocationData);

                    // Add the item to the collection of items that will be included in the batched event arguments.
                    updatedVehicleLocations.Add(vehicleLocationData);
                }


                if (updatedVehicleLocations.Any())
                {
                    this.OnVehicleLocationUpdate?.Invoke(this, new VehiclesLocationUpdatedEventArgs(updatedVehicleLocations));
                    updatedVehicleLocations.Clear();
                }

                await Task.Delay(this.delayToWaitBeetweenUpdates, token);
            }
        }
    }
}