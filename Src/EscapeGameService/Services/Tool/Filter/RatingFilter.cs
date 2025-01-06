namespace EscapeGameService.Services.Tool.Filter
{
    public class RatingFilter
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int? EscapeGameId { get; set; }
        public string? UserId { get; set; }
        public int? MinRating { get; set; }
        public int? MaxRating { get; set; }
        public DateTime? Created { get; set; }
    }
}
