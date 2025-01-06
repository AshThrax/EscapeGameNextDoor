
namespace NotificationService.Services
{
    public class NotificationService : Service<Notification, GetNotificationDto, AddNotificationDto, UpdateNotificationDto>, INotificationService
    {
        public NotificationService(IRepository<Notification> repository, IMapper map) : base(repository, map)
        {
        }
    }
}
