namespace EscapeGameService.Models
{
    public class HasBeenDone
    {
        public int HbdId { get; set; }
        public int EscapeGameId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public Escapegame? Escapegame { get; set; }
    }
}
