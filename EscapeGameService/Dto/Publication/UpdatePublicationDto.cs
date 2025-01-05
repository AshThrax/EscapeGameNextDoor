using EscapeGameService.Dto.Base;

namespace EscapeGameService.Dto
{
    public class UpdatePublicationDto : UpdateDto
    {
        public int PubId { get; set; }
        public int EscapegameId { get; set; }
        public string Content { get; set; } = string.Empty;
        public int LikeNumber { get; set; }
        public string userId { get; set; } = string.Empty;

    }
}
