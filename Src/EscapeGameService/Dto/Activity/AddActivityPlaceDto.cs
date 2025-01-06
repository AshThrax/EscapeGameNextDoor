using EscapeGameService.Dto.Base;

namespace EscapeGameService.Dto
{
    public class AddActivityPlaceDto : AddDto
    {
        public int AcpEsgId { get; set; }
        public ActivityPlacesType? ActivityType { get; set; }
        public int ActivityId { get; set; }
        public string Adress { get; set; } = string.Empty;
        public string Imgressources { get; set; } = string.Empty;
    }
}
