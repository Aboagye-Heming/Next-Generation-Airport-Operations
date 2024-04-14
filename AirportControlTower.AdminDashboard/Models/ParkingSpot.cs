namespace AirportControlTower.Models
{
    public class ParkingSpot
    {
        public int Id { get; set; }
        public string SpotNumber { get; set; } = string.Empty;
        public bool IsOccupied { get; set; }
        public string AircraftCallSign { get; set; } = string.Empty;// Optional, link to the parked Aircraft if any
    }
}
