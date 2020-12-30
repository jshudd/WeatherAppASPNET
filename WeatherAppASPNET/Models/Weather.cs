using System;
namespace WeatherAppASPNET.Models
{
    public class Weather
    {
        public Weather()
        {
        }

        public int CurrentCondition { get; set; }
        public double CurrentTemp { get; set; }
        public double FeelsLike { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public double WindSpeed { get; set; }
        public double WindGust { get; set; }
        public int Zip { get; set; }
    }
}
