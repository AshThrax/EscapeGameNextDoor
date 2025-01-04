namespace EscapeGameService.Services.Tool.Filter
{
    public class PublicationFilter
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int EscapeGameId { get; set; }
        public string UserId { get; set; } =string.Empty;
        public int PublicationTypeId { get; set; }

    }
}
