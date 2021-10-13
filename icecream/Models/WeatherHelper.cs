using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace icecream.Models
{
    public class WeatherHelper
    {
        public Main CheckWeather(string city)
        {
            string apiKey = "efe83d986e7db538087a0a3355daeff8";
  
            var client = new RestClient("https://api.openweathermap.org/data/2.5/weather");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("q", city);
            request.AddParameter("appid", apiKey);
            request.AddParameter("units", "metric");
            IRestResponse response = client.Execute(request);
            Root2 TheTags = JsonConvert.DeserializeObject<Root2>(response.Content);

            return TheTags.main;
        }
    }
}
    
