namespace EscapeGameService.Dto.SessionReserved
{
    public class AddSessionReservedDto
    {
        public string Content { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public int SessionGameId { get; set; }
        public bool IsCancel { get; set; }
        public bool IsConfirmed { get; set; }

    }
}
