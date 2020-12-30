using System;
namespace WeatherAppASPNET
{
    public interface IGetWeather
    {
        public void GetLocalWeather(int zipCode);
    }
}
