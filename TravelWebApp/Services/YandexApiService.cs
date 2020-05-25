using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.Services
{
    public class YandexApiService
    {
        public dynamic GetScheduleBetweenStations(string stationFromCode, string stationToCode)
        {
            var answer = "";
            var request = System.Net.WebRequest.Create("https://api.rasp.yandex.net/v3.0/search/?apikey=1a54691b-37d6-4213-ad2c-90d1c5a2a7e7&lang=ru_RU&format=json&from="+stationFromCode+"&to="+stationToCode);
            using (System.Net.WebResponse response = request.GetResponse())
            {
                using (System.IO.StreamReader rd = new System.IO.StreamReader(response.GetResponseStream()))
                {
                    answer = rd.ReadToEnd();

                }
            }
            var values = JsonConvert.DeserializeObject<dynamic>(answer);
            return values;
        }
    }
}
