using EscapeGameService.Dto.Base;

namespace EscapeGameService.Dto.Event
{
    public class AddEventDto :AddDto
    {

        public int EscapegameId { get; set; }
        public string EventTitle { get; set; } = string.Empty;
        public string EventDescription { get; set; } = string.Empty;
     
    }
}
