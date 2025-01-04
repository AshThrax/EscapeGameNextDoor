namespace EscapeGameService.Services.Tool.Filter
{
    public class EscapeGameFilter
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int CategoriesId { get; set; }
        public int DifficultyId { get; set; }
        public int PriceId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
