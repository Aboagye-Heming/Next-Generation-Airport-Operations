namespace AirportControlTower.Models
{
    public class StateChangeLog
    {
        public int Id { get; set; }
        public string AircraftCallSign { get; set; } = string.Empty;
        public string OldState { get; set; } = string.Empty;
        public string NewState { get; set; } = string.Empty;
        public DateTime ChangedAt { get; set; }
    }
}
