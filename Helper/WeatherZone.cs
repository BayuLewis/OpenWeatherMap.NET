namespace OpenWeatherMap.NET.Helper
{
    public class WeatherZone
    {
        /// <summary>
        ///     This will help get weather data within a rectangle zone
        /// </summary>
        /// <param name="lonLeft"></param>
        /// <param name="latBottom"></param>
        /// <param name="lonRight"></param>
        /// <param name="latTop"></param>
        /// <param name="zoom"></param>
        public WeatherZone(int lonLeft, int latBottom, int lonRight, int latTop, int zoom)
        {
            LatBot = latBottom;
            LatTop = latTop;
            LonLeft = lonLeft;
            LonRight = lonRight;
            Zoom = zoom;
        }
        
        /// <summary>
        ///     Latitude Bottom
        /// </summary>
        public int LatBot { get; }
        
        /// <summary>
        /// Latitude Top
        /// </summary>
        public int LatTop { get; }
        
        /// <summary>
        /// Longitude Left
        /// </summary>
        public int LonLeft { get;}
        
        /// <summary>
        /// Longitude Right
        /// </summary>
        public int LonRight { get;}
        
        /// <summary>
        /// Zoom
        /// </summary>
        public int Zoom { get; }
        
        /// <summary>
        ///     ToZoneString Will convert to string for specific ints above
        /// </summary>
        /// <returns></returns>
        public string ToZoneString() => $"{LonLeft},{LatBot},{LonRight},{LatTop},{Zoom}";
    }
}