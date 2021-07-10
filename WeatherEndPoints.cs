using System;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using OpenWeatherMap.NET.Models;
using static OpenWeatherMap.NET.Constants;

namespace OpenWeatherMap.NET
{
    /// <summary>
    ///     OpenWeatherMap Weather Endpoints
    /// </summary>
    public partial class OpenWeatherMapAPI
    {
        /// <summary>
        ///     Get Weather Data by City Name
        /// </summary>
        /// <param name="cityName"></param>
        /// <param name="stateCode"></param>
        /// <param name="countryCode"></param>
        /// <returns>Weather Data for a specific location</returns>
        /// <exception cref="OpenWeatherMapException"></exception>
        public async Task<OneLocation> GetWeatherDataByCityName(string cityName, string stateCode = "", string countryCode= "")
        {
            var request = new RestRequest(WEATHER_ENDPOINT, DataFormat.Json);
            request.AddQueryParameter("q", cityName);
            if (!string.IsNullOrEmpty(stateCode)) string.Join(cityName, ",");
            if (!string.IsNullOrEmpty(countryCode)) string.Join(cityName, ",");
            var response = await Client.ExecuteGetAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new OpenWeatherMapException(
                    $"{(int) response.StatusCode}: {(JObject.Parse(response.Content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<OneLocation>(content);
        }
        
        /// <summary>
        ///     Get Weather Data by CityID
        /// </summary>
        /// <param name="cityID"></param>
        /// <returns>Weather Data for a specific location</returns>
        /// <exception cref="OpenWeatherMapException"></exception>
        public async Task<OneLocation> GetWeatherDataByCityId(string cityID)
        {
            var request = new RestRequest(WEATHER_ENDPOINT, DataFormat.Json);
            request.AddQueryParameter("id", cityID);
            var response = await Client.ExecuteGetAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new OpenWeatherMapException(
                    $"{(int) response.StatusCode}: {(JObject.Parse(response.Content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<OneLocation>(content);
        }
        
        /// <summary>
        ///     Get Weather Data by Longitude and Latitude
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lon"></param>
        /// <returns>Weather Data for a specific location</returns>
        /// <exception cref="OpenWeatherMapException"></exception>
        public async Task<OneLocation> GetWeatherDataByLonAndLat(string lat, string lon)
        {
            var request = new RestRequest(WEATHER_ENDPOINT, DataFormat.Json);
            request.AddQueryParameter("lat", lat);
            request.AddQueryParameter("lon", lon);
            var response = await Client.ExecuteGetAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new OpenWeatherMapException(
                    $"{(int) response.StatusCode}: {(JObject.Parse(response.Content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<OneLocation>(content);
        }
        
        /// <summary>
        ///     Get Weather Data by ZipCode
        /// </summary>
        /// <param name="zipCode"></param>
        /// <param name="countryCode"></param>
        /// <returns>Weather Data for a specific Location</returns>
        /// <exception cref="OpenWeatherMapException"></exception>
        public async Task<OneLocation> GetWeatherDataByZipCode(string zipCode, string countryCode = "")
        {
            var request = new RestRequest(WEATHER_ENDPOINT, DataFormat.Json);
            request.AddQueryParameter("zip", zipCode);
            if (!string.IsNullOrEmpty(countryCode)) string.Join(zipCode, ",");
            var response = await Client.ExecuteGetAsync(request);
            var content = response.Content;
            if (!response.IsSuccessful)
                throw new OpenWeatherMapException(
                    $"{(int) response.StatusCode}: {(JObject.Parse(response.Content)["error"] ?? "").Value<string>()}");
            return JsonConvert.DeserializeObject<OneLocation>(content);
        }
    }
}