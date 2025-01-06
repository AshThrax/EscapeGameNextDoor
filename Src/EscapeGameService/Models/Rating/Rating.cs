namespace EscapeGameService.Models
{
    public class Rating
    {
        public int RateId { get; set; }
        public string RateContent { get; set; } = string.Empty;
        public int HasBeenDoneId { get; set; }
        //navigation
        public HasBeenDone? HasbeenDone { get; set; }
    }
}
