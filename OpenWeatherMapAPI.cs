using System;
using RestSharp;
using static OpenWeatherMap.NET.Constants;

namespace OpenWeatherMap.NET
{
    /// <summary>
    ///     OpenWeatherMapAPI class
    /// </summary>
    public partial class OpenWeatherMapAPI
    {
        private readonly RestClient Client;
        
        /// <summary>
        ///     API for OpenWeatherMap
        /// </summary>
        /// <param name="apiKey"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public OpenWeatherMapAPI(string apiKey)
        {
            ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            Client = new RestClient(API_URL);
            Client.AddDefaultParameter("appid", ApiKey);
        }
        
        private string ApiKey { get; }
    }
}