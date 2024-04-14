namespace AirportControlTower.Models
{
    public class Aircraft
    {
        public int Id { get; set; }
        public string CallSign { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty; // Example: AIRLINER, CARGO, PRIVATE, etc.
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Altitude { get; set; }
        public int Heading { get; set; }
        public string State { get; set; } = string.Empty;// Example: APPROACH, DEPARTED, LANDED, PARKED, etc.
        public string ApiKey { get; set; } = string.Empty;//  store the API Key

    }
}
