using EscapeGameService.Dto.Base;

namespace EscapeGameService.Dto.Event
{
    public class UpdateEventDto : UpdateDto
    {
        public int EventId { get; set; }
        public int EscapegameId { get; set; }
        public Escapegame? Escapegame { get; set; }
        public string EventTitle { get; set; } = string.Empty;
        public string EventDescription { get; set; } = string.Empty;
    }
}
