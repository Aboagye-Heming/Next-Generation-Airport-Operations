namespace AirportControlTower.Models
{
    public class Weather
    {
        public int Id { get; set; }
        public string AirportCode { get; set; }  = string.Empty;// Identifier for airport weather station
        public DateTime Timestamp { get; set; }
        public double Temperature { get; set; } // Celsius
        public double WindSpeed { get; set; } // km/h
        public int WindDirection { get; set; } // Degrees from true north
        public double Humidity { get; set; } // Relative humidity in %
        public string Conditions { get; set; }  = string.Empty;// Example: Clear, Rainy, Cloudy, etc.
    }
}
