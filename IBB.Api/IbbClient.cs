using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using IBB.Api.Models;
using IBB.Wsdl.DurakHatDetay;
using IBB.Wsdl.HatDurak;
using IBB.Wsdl.Seferler;
using Newtonsoft.Json;

namespace IBB.Api
{
    public class IbbClient : IIbbClient
    {
        #region Connected Services
        private readonly HatDurakSoapClient hatDurakSoapClient;
        private readonly SeferGerceklesmeSoapClient seferSoapClient;
        private readonly IbbSoapClient hatDurakDetayClient;
        #endregion

        public IbbClient()
        {
            this.hatDurakSoapClient  = new HatDurakSoapClient();
            this.seferSoapClient     = new SeferGerceklesmeSoapClient();
            this.hatDurakDetayClient = new IbbSoapClient();
        }

        /// <summary>
        ///     Tüm Garaj Listesi.
        /// </summary>
        /// <returns>Garaj Listesi</returns>
        public async Task<IEnumerable<GarajResponse>> GetGarajAsync()
        {
            GetGaraj_jsonResponse garajJsonAsync = await this.hatDurakSoapClient.GetGaraj_jsonAsync();
            string jsonResponse = garajJsonAsync.Body.GetGaraj_jsonResult;

            return JsonConvert.DeserializeObject<GarajResponse[]>(jsonResponse);
        }

        /// <summary>
        ///     Tüm Durak Listesi.
        /// </summary>
        /// <returns>Durak Listesi</returns>
        public async Task<IEnumerable<DurakResponse>> GetDurakAsync()
        {
            GetDurak_jsonResponse durakJsonAsync = await this.hatDurakSoapClient.GetDurak_jsonAsync("");
            string jsonResponse = durakJsonAsync.Body.GetDurak_jsonResult;

            return JsonConvert.DeserializeObject<DurakResponse[]>(jsonResponse);
        }

        /// <summary>
        ///     Durak kodu
        /// </summary>
        /// <param name="durakKodu">Aranan durak</param>
        /// <returns>Durak</returns>
        public async Task<IEnumerable<DurakResponse>> GetDurakAsync(int durakKodu)
        {
            GetDurak_jsonResponse durakJsonAsync =
                await this.hatDurakSoapClient.GetDurak_jsonAsync(durakKodu.ToString());
            string jsonResponse = durakJsonAsync.Body.GetDurak_jsonResult;

            return JsonConvert.DeserializeObject<DurakResponse[]>(jsonResponse);
        }

        /// <summary>
        ///     Araclarin guncel konum bilgileri.
        /// </summary>
        /// <returns>Anlık araç konum bilgileri</returns>
        public async Task<IEnumerable<AracKonumuResponse>> GetAracKonumlariAsync()
        {
            GetFiloAracKonum_jsonResponse aracKonumJsonResponse = await this.seferSoapClient.GetFiloAracKonum_jsonAsync();

            string jsonResponse = aracKonumJsonResponse.Body.GetFiloAracKonum_jsonResult;

            return JsonConvert.DeserializeObject<AracKonumuResponse[]>(jsonResponse);
        }

        /// <summary>
        ///     Yapılan Kazaların X, Y koordinatlarını içermektedir.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public async Task<IEnumerable<KazaLokasyonResponse>> GetKazaLokasyonAsync(DateTime date)
        {
            GetKazaLokasyon_jsonResponse result = await this.seferSoapClient.GetKazaLokasyon_jsonAsync(date.ToString("yyyy-MM-dd"));

            return JsonConvert.DeserializeObject<KazaLokasyonResponse[]>(result.Body.GetKazaLokasyon_jsonResult);
        }

        /// <summary>
        ///     Tum otobus hatlarin tum duraklari
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<DurakDetayResponse>> GetDurakDetayAsync() => await this.GetDurakDetayAsync("");

        /// <summary>
        ///     Bir otobus hattinin duraklari. 
        /// </summary>
        /// <param name="hatKodu">Otobus hat kodu</param>
        /// <returns></returns>
        public async Task<IEnumerable<DurakDetayResponse>> GetDurakDetayAsync(string hatKodu)
        {
            DurakDetay_GYYResponse result = await this.hatDurakDetayClient.DurakDetay_GYYAsync(hatKodu);

            string xml = result.Body.DurakDetay_GYYResult.ToString();

            XmlSerializer serializer = new XmlSerializer(typeof(DurakDetayXmlRoot));

            using (TextReader reader = new StringReader(xml))
            {
                DurakDetayXmlRoot xmlRoot = (DurakDetayXmlRoot) serializer.Deserialize(reader);
                return xmlRoot.Table;
            }
        }

        /// <summary>
        ///     Tum otobus hatlarin servis detaylari
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<HatServisResponse>> GetHatServisAsync() => await this.GetHatServisAsync("");

        /// <summary>
        ///     Bir otobus hattinin servis detaylari
        /// </summary>
        /// <param name="hatKodu">Otobus hat kodu</param>
        /// <returns>Hat servis detaylari</returns>
        public async Task<IEnumerable<HatServisResponse>> GetHatServisAsync(string hatKodu)
        {
            HatServisi_GYYResponse result = await this.hatDurakDetayClient.HatServisi_GYYAsync(hatKodu);

            XmlSerializer serializer = new XmlSerializer(typeof(HatServisXmlRoot));

            using (TextReader reader = new StringReader(result.Body.HatServisi_GYYResult.ToString()))
            {
                HatServisXmlRoot xmlRoot = (HatServisXmlRoot) serializer.Deserialize(reader);
                List<HatServisResponse> response = xmlRoot.HatServisResponse;
                return response;
            }
        }
    }
}