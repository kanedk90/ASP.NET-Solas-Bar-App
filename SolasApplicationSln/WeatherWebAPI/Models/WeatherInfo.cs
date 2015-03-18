using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherWebAPI.Models
{
        public enum WeatherDescription
        {
            sunny,
            miserable,
            woulditEverStopRaining
        }

        public class WeatherInfo
        {
            public int Id { get; set; }
            public string Location { get; set; }
            public WeatherDescription Weather { get; set; }
            public float Temperature { get; set; }
        }

    
}