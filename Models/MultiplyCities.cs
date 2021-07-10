using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenWeatherMap.NET.Models.MultiplyCities
{
    /// <summary>
    /// Json properties for MultiplyCites call
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

    public class Main
    {
        /// <summary>
        /// Temperature
        /// </summary>
        [JsonProperty("temp")]
        public double Temp { get; set; }
        
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
        
        /// <summary>
        /// Pressure
        /// </summary>

        [JsonProperty("pressure")]
        public double Pressure { get; set; }
        
        /// <summary>
        /// Sea Level
        /// </summary>

        [JsonProperty("sea_level")]
        public double SeaLevel { get; set; }
        
        /// <summary>
        /// Ground Level
        /// </summary>

        [JsonProperty("grnd_level")]
        public double GrndLevel { get; set; }
        
        /// <summary>
        /// Humidity 
        /// </summary>

        [JsonProperty("humidity")]
        public int Humidity { get; set; }
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
        public double Deg { get; set; }
        
        /// <summary>
        /// ...
        /// </summary>
        [JsonProperty("var_beg")]
        public int? VarBeg { get; set; }
        
        /// <summary>
        /// ...
        /// </summary>
        [JsonProperty("var_end")]
        public int? VarEnd { get; set; }
    }

    public class Rain
    {
        /// <summary>
        /// Rain Information in 3 hours
        /// </summary>
        [JsonProperty("3h")]
        public double _3h { get; set; }
    }

    public class Clouds
    {
        /// <summary>
        /// Clouds Level
        /// </summary>
        [JsonProperty("all")]
        public int All { get; set; }
    }

    public class Weather
    {
        /// <summary>
        /// Weather ID
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

    public class List
    {
        /// <summary>
        /// City IDs
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        
        /// <summary>
        /// City name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Coordinates
        /// </summary>
        [JsonProperty("coord")]
        public Coord Coord { get; set; }
        
        /// <summary>
        /// Main Weather
        /// </summary>
        [JsonProperty("main")]
        public Main Main { get; set; }
        
        /// <summary>
        /// Date Time
        /// </summary>
        [JsonProperty("dt")]
        public int Dt { get; set; }
        
        /// <summary>
        /// Wind Data
        /// </summary>
        [JsonProperty("wind")]
        public Wind Wind { get; set; }
        
        /// <summary>
        /// Rain Data
        /// </summary>
        [JsonProperty("rain")]
        public Rain Rain { get; set; }
        
        /// <summary>
        /// Clouds Level
        /// </summary>
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }
        
        /// <summary>
        /// Weather Data
        /// </summary>
        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }
    }

    public class MultiplyCities
    {
        /// <summary>
        /// Internal parameter
        /// </summary>
        [JsonProperty("cod")]
        public string Cod { get; set; }
        
        /// <summary>
        /// Calculation Time
        /// </summary>
        [JsonProperty("calctime")]
        public double Calctime { get; set; }
        
        /// <summary>
        /// Number of Cities
        /// </summary>
        [JsonProperty("cnt")]
        public int Cnt { get; set; }
        
        /// <summary>
        /// List of Cities
        /// </summary>
        [JsonProperty("list")]
        public List<List> List { get; set; }
    }
}