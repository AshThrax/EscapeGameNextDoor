using EscapeGameService.Dto.Base;

namespace EscapeGameService.Dto.Event
{
    public class GetEventDto : BaseDto
    {
        public int EventId { get; set; }
        public int EscapegameId { get; set; }
        public string EventTitle { get; set; } = string.Empty;
        public string EventDescription { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    
    }
}
