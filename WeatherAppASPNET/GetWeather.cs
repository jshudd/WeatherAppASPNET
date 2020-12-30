using System;
namespace WeatherAppASPNET
{
    public class GetWeather : IGetWeather
    {
        public GetWeather()
        {
        }

        void IGetWeather.GetLocalWeather(int zipCode)
        {
            throw new NotImplementedException();
        }
    }
}
