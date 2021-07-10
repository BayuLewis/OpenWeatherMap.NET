using System;

namespace OpenWeatherMap.NET
{
    public class OpenWeatherMapException : Exception
    {
        /// <summary>
        ///     Exception for OpenWeatherMap
        /// </summary>
        /// <param name="message"></param>
        public OpenWeatherMapException(string message) : base(message)
        {
        }

        public override string StackTrace => "";
    }
}