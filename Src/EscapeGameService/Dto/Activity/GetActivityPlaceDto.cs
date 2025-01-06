using EscapeGameService.Dto.Base;

namespace EscapeGameService.Dto
{
    public class GetActivityPlaceDto: BaseDto
    {
        public int AcpId { get; set; }
        public int AcpEsgId { get; set; }
        public ActivityPlacesType? ActivityType { get; set; }
        public int ActivityId { get; set; }
        public string Adress { get; set; } = string.Empty;
        public string Imgressources { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}
