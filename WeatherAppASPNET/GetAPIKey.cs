using System;
using Newtonsoft.Json.Linq;
using System.IO;

namespace WeatherAppASPNET
{
    public class GetAPIKey
    {
        private readonly string _apiKey;

        public GetAPIKey(string APIKey)
        {
            string key = File.ReadAllText("appsettings.json");
            APIKey = JObject.Parse(key).GetValue("DefaultKey").ToString();

            _apiKey = APIKey;
        }
    }
}
