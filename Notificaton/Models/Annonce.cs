namespace NotificationService.Models
{
    public class Annonce
    {
        public int Id { get; set; }
        public string Name { get; set; } =string .Empty;
        public string Description { get; set; }=string .Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set;} = DateTime.Now;

    }
}
