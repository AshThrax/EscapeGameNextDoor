namespace EscapeGameService.Models
{
    public class Publication
    {
        public int PubId { get; set; }
        public int EscapegameId { get; set; }
        public string Content { get; set; } = string.Empty;
        public int LikeNumber { get; set; }
        public bool IsDeleted { get; set; }
        public string userId { get; set; } = string.Empty;
        //navigation 
        PublicationType? PublicationType { get; set; }
        public HasLike? HasLike { get; set; }
    }
}
