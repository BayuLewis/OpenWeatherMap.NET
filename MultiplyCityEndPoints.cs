using OpenWeatherMap.NET.Models.MultiplyCities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static OpenWeatherMap.NET.Constants;
using System.Threading.Tasks;
using System;
using OpenWeatherMap.NET.Helper;
using RestSharp;

namespace OpenWeatherMap.NET
{
    /// <summary>
    ///     OpenWeatherMap Multiply Cities Endpoints
    ///     This class help you get a list of city weather condition
    /// </summary>
    public partial class OpenWeatherMapAPI
    {
        /// <summary>
        ///     Get Weather Data With many within a Rectangle Zone
        ///     This will help you get a list of Weather Data for many countries/cities
        ///     Check WeatherZone.cs for more information about this
        /// </summary>
        /// <param name="zone"></param>
        /// <returns>Weather Data within a rectangle zone</returns>
        /// <exception cref="OpenWeatherMapException"></exception>
        public async Task<MultiplyCities> GetWeatherDataWithinARectangleZone(WeatherZone zone)
        {
            var request = new RestRequest(BOX_ENDPOINTS, DataFormat.Json);
            request.AddParameter("bbox", zone.ToZoneString());
            var response = await Client.ExecuteGetAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new OpenWeatherMapException(
                    $"{(int) response.StatusCode}: {(JObject.Parse(response.Content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<MultiplyCities>(content);
        }
        
        /// <summary>
        ///     Get Weather Data In Cities Circle
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lon"></param>
        /// <param name="cnt"></param>
        /// <returns>Weather Data In Cities Circles</returns>
        /// <exception cref="OpenWeatherMapException"></exception>
        public async Task<MultiplyCities> GetWeatherDataInCircles(string lat, string lon, string cnt = "")
        {
            var request = new RestRequest(FIND_ENDPOINTS, DataFormat.Json);
            request.AddParameter("lat", lat);
            request.AddParameter("lon", lon);
            if (!string.IsNullOrEmpty(cnt)) request.AddParameter("cnt", cnt);
            var response = await Client.ExecuteGetAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new OpenWeatherMapException(
                    $"{(int) response.StatusCode}: {(JObject.Parse(response.Content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<MultiplyCities>(content);
        }
    }
}