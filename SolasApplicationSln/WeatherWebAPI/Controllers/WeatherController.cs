using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeatherWebAPI.Models;

namespace WeatherWebAPI.Controllers
{
    public class WeatherController : ApiController
    {
        //We have no database set up, so we are hardwiring the weather info (locations etc..)
        //In a real application this info would be stored in a databse and we would retieve it from there
        List<WeatherInfo> info = new List<WeatherInfo>
        { 
            new WeatherInfo { Id = 1, Location = "Dublin", Weather = WeatherDescription.sunny, Temperature=18 }, 
            new WeatherInfo { Id = 2, Location = "Cork",   Weather = WeatherDescription.miserable, Temperature=10  }, 
            new WeatherInfo { Id = 3, Location = "Galway", Weather = WeatherDescription.woulditEverStopRaining, Temperature=6}           
        };

        //The URL http://localhost:15427/api/Weather maps to this method
        public IEnumerable<WeatherInfo> GetAllWeather()   //the URL .. maps to this method
        {
            return info;
        }

        // The URL http://localhost:15427/api/Weather/2 maps to this method, where 2 maps to the ID parameter 
        public IHttpActionResult GetWeather(int id)        //the URL .. maps to this method
        {
            var product = info.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }


}

