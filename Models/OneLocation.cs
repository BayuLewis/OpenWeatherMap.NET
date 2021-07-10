using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenWeatherMap.NET.Models
{
    /// <summary>
    /// Json Properties for OneLocation Call
    /// </summary>
     public class Coord
    {
        /// <summary>
        /// Longitude
        /// </summary>
        [JsonProperty("lon")]
        public double Lon { get; set; }
        
        /// <summary>
        /// Latitude
        /// </summary>
        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class Weather
    {
        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        
        /// <summary>
        /// Main Weather
        /// </summary>
        [JsonProperty("main")]
        public string Main { get; set; }
        
        /// <summary>
        /// Weather Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        
        /// <summary>
        /// Weather Icon
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }

    public class Main
    {
        /// <summary>
        /// Temperature
        /// </summary>
        [JsonProperty("temp")]
        public double Temp { get; set; }
        
        /// <summary>
        /// Pressure
        /// </summary>
        [JsonProperty("pressure")]
        public int Pressure { get; set; }
        
        /// <summary>
        /// Humidity
        /// </summary>
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        
        /// <summary>
        /// Minimum Temperature
        /// </summary>
        [JsonProperty("temp_min")]
        public double TempMin { get; set; }
        
        /// <summary>
        /// Maximum Temperature
        /// </summary>
        [JsonProperty("temp_max")]
        public double TempMax { get; set; }
    }

    public class Wind
    {
        /// <summary>
        /// Wind Speed
        /// </summary>
        [JsonProperty("speed")]
        public double Speed { get; set; }
        
        /// <summary>
        /// Wind Degrees
        /// </summary>
        [JsonProperty("deg")]
        public int Deg { get; set; }
    }

    public class Clouds
    {
        /// <summary>
        /// Clouds level
        /// </summary>
        [JsonProperty("all")]
        public int All { get; set; }
    }

    public class Sys
    {
        /// <summary>
        /// Internal Parameter
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }
        
        /// <summary>
        /// Internal parameter
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        
        /// <summary>
        /// Internal parameter
        /// </summary>
        [JsonProperty("message")]
        public double Message { get; set; }
        
        /// <summary>
        /// Country Code
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
        
        /// <summary>
        /// Sunrise time
        /// </summary>
        [JsonProperty("sunrise")]
        public int Sunrise { get; set; }
        
        /// <summary>
        /// Sunset Time
        /// </summary>
        [JsonProperty("sunset")]
        public int Sunset { get; set; }
    }

    public class OneLocation
    {
        /// <summary>
        /// Coordinates
        /// </summary>
        [JsonProperty("coord")]
        public Coord Coord { get; set; }
        
        /// <summary>
        /// Weather Data
        /// </summary>
        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }
        
        /// <summary>
        /// Internal parameter
        /// </summary>
        [JsonProperty("base")]
        public string Base { get; set; }
        
        /// <summary>
        /// Main 
        /// </summary>
        [JsonProperty("main")]
        public Main Main { get; set; }
        
        /// <summary>
        /// Visibility Value
        /// </summary>
        [JsonProperty("visibility")]
        public int Visibility { get; set; }
        
        /// <summary>
        /// Wind Data
        /// </summary>
        [JsonProperty("wind")]
        public Wind Wind { get; set; }
        
        /// <summary>
        /// Cloud Data
        /// </summary>
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }
        
        /// <summary>
        /// DateTime
        /// </summary>
        [JsonProperty("dt")]
        public int Dt { get; set; }
        
        /// <summary>
        /// Sys Data
        /// </summary>
        [JsonProperty("sys")]
        public Sys Sys { get; set; }
        
        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        
        /// <summary>
        /// City Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Internal Parameter
        /// </summary>
        [JsonProperty("cod")]
        public int Cod { get; set; }
    }
}