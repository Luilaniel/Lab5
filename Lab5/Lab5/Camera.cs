using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Camera
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CountryOfOrigin { get; set; }
        public string SensorType { get; set; }
        public int SensorResolution { get; set; }
        public string LensType { get; set; }
        public string VideoFormat { get; set; }
        public bool WeatherSealing { get; set; }
        public string GetFullName()
        {
            return Brand + " " + Model;
        }
        public Camera()
        { 
        }
        public Camera(string brand, string model, string country, string sensorType,
            int sensorResolution, string lensType, string videoFormat, bool hasWeatherSealing)
        {
            Brand = brand; Model = model; CountryOfOrigin = country; SensorType = sensorType;
            SensorResolution = sensorResolution; LensType = lensType; VideoFormat = videoFormat;
            WeatherSealing = hasWeatherSealing;

        }
    }
}
