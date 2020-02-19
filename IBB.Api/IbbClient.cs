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

        public async Task<IEnumerable<BusGarageResponse>> GetGaragesAsync()
        {
            GetGaraj_jsonResponse garajJsonAsync = await this.hatDurakSoapClient.GetGaraj_jsonAsync();
            string jsonResponse = garajJsonAsync.Body.GetGaraj_jsonResult;

            return JsonConvert.DeserializeObject<BusGarageResponse[]>(jsonResponse);
        }

        public async Task<IEnumerable<BusStopResponse>> GetBusStopsAsync()
        {
            GetDurak_jsonResponse durakJsonAsync = await this.hatDurakSoapClient.GetDurak_jsonAsync("");
            string jsonResponse = durakJsonAsync.Body.GetDurak_jsonResult;

            return JsonConvert.DeserializeObject<BusStopResponse[]>(jsonResponse);
        }

        public async Task<IEnumerable<BusStopResponse>> GetBusStopsAsync(int busStopId)
        {
            GetDurak_jsonResponse durakJsonAsync =
                await this.hatDurakSoapClient.GetDurak_jsonAsync(busStopId.ToString());
            string jsonResponse = durakJsonAsync.Body.GetDurak_jsonResult;

            return JsonConvert.DeserializeObject<BusStopResponse[]>(jsonResponse);
        }

        public async Task<IEnumerable<VehicleLocationResponse>> GetVehicleLocationsAsync()
        {
            GetFiloAracKonum_jsonResponse aracKonumJsonResponse = await this.seferSoapClient.GetFiloAracKonum_jsonAsync();

            string jsonResponse = aracKonumJsonResponse.Body.GetFiloAracKonum_jsonResult;

            return JsonConvert.DeserializeObject<VehicleLocationResponse[]>(jsonResponse);
        }

        public async Task<IEnumerable<AccidentLocationResponse>> GetAccidentsLocationDataAsync(DateTime date)
        {
            GetKazaLokasyon_jsonResponse result = await this.seferSoapClient.GetKazaLokasyon_jsonAsync(date.ToString("yyyy-MM-dd"));

            return JsonConvert.DeserializeObject<AccidentLocationResponse[]>(result.Body.GetKazaLokasyon_jsonResult);
        }
        
        public async Task<IEnumerable<BusRouteResponse>> GetBusRouteDetailsAsync() => await this.GetBusRouteDetailsAsync("");

        public async Task<IEnumerable<BusRouteResponse>> GetBusRouteDetailsAsync(string busRouteId)
        {
            DurakDetay_GYYResponse result = await this.hatDurakDetayClient.DurakDetay_GYYAsync(busRouteId);

            string xml = result.Body.DurakDetay_GYYResult.ToString();

            XmlSerializer serializer = new XmlSerializer(typeof(DurakDetayXmlRoot));

            using (TextReader reader = new StringReader(xml))
            {
                DurakDetayXmlRoot xmlRoot = (DurakDetayXmlRoot) serializer.Deserialize(reader);
                return xmlRoot.Table;
            }
        }

        public async Task<IEnumerable<BusServiceDetailResponse>> GetBusServiceDetailsAsync() => await this.GetBusServiceDetailsAsync("");

        public async Task<IEnumerable<BusServiceDetailResponse>> GetBusServiceDetailsAsync(string busRouteId)
        {
            HatServisi_GYYResponse result = await this.hatDurakDetayClient.HatServisi_GYYAsync(busRouteId);

            XmlSerializer serializer = new XmlSerializer(typeof(HatServisXmlRoot));

            using (TextReader reader = new StringReader(result.Body.HatServisi_GYYResult.ToString()))
            {
                HatServisXmlRoot xmlRoot = (HatServisXmlRoot) serializer.Deserialize(reader);
                List<BusServiceDetailResponse> response = xmlRoot.BusServiceDetailResponse;
                return response;
            }
        }
    }
}