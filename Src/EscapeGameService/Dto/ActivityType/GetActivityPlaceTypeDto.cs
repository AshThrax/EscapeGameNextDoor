using EscapeGameService.Dto.Base;

namespace EscapeGameService.Dto.ActivityType
{
    public class GetActivityPlaceTypeDto : BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
