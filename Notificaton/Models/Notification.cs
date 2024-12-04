namespace NotificationService.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string  Title { get; set; }=string.Empty;
        public string Content { get; set; }=string.Empty;
        public bool IsRead { get; set; }
        public int NotificationTypeId { get; set; }
        public NotificationType NotificationType { get; set; } = new NotificationType();
        public string UserId { get; set; } = string .Empty;
        public DateTime? CreationDate { get; set;}
        public DateTime? UpdatedDate { get; set;}
    }
}
