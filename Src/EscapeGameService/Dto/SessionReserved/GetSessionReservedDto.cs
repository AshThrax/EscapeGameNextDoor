using EscapeGameService.Dto.SessionGame;

namespace EscapeGameService.Dto.SessionReserved
{
    public class GetSessionReservedDto
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public int SessionGameId { get; set; }
        public GetSessionGameDto? SessionGame { get; set; }
        public bool IsCancel { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
