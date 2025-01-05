namespace EscapeGameService.Dto.HasLike
{
    public class AddHasLikeDto
    {
    
        public int PubId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public int TypeLikeId { get; set; }
     
    }
}
