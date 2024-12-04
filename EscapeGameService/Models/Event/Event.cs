namespace EscapeGameService.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public int EscapegameId { get; set; }
        public Escapegame? Escapegame { get; set; }
        public string EventTitle { get; set; } = string.Empty;
        public string EventDescription { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
