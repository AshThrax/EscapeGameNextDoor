namespace EscapeGameService.Models
{
    public class SessionReserved
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public int SessionGameId { get; set; }
        public SessionGame? SessionGame { get; set; }
        public bool IsCancel { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
