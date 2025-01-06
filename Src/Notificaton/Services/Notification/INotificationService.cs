using NotificationService.Services;

namespace NotificationService.Services
{
    public interface INotificationService : IService<Notification,GetNotificationDto,AddNotificationDto,UpdateNotificationDto>
    {
    }
}
