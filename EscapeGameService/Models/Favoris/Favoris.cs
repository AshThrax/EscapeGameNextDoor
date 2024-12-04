namespace EscapeGameService.Models
{
    public class Favoris
    {

        public int EscapeGameId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        //---navigation----------------------------
        public Escapegame? Escapegame { get; set; }
    }
}
