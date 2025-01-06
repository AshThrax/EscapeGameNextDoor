namespace EscapeGameService.Models
{
    public class HasLike
    {
        public int Id { get; set; }
        public int PubId { get; set; }
        public string UserId { get; set; } = string.Empty;

        public TypeLike? TypeLIke { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public Publication? Publication { get; set; }
    }
}
