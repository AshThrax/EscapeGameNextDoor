namespace EscapeGameService.Services.Tool.Filter
{
    public class SignalementFilter
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int ? EscapeGameId { get; set; }
        public DateTime? Date { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
        public bool? HasAvailablePlaces { get; set; }
    }
}
