using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherWebAPI.Models

//namespace SolasWebAPI.Models
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
    
    
    
    /*
    public enum ReviewDescription
    {
        bad,
        good,
        excellent
    }
    public class ReviewInfo
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public  ReviewDescription Body { get; set; }
        public int Rating { get; set; }
    }
   
}*/