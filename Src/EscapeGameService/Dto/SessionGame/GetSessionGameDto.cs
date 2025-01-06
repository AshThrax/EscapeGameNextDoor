namespace EscapeGameService.Dto.SessionGame
{
    public class GetSessionGameDto
    {
        public int SegId { get; set; }
        public int EscapeGameId { get; set; }
        public TimeOnly GameTime { get; set; }
        public DateOnly GameDate { get; set; }
        public int Price { get; set; }
        public int Placeavailable { get; set; }
        public int PLacemaximum { get; set; }
    }
}
