using NotificationService.Data;
using NotificationService.Models;

namespace NotificationService.Repository
{
    public class NotificationRepository : Repository<Notification>, INotificationRepository
    {
        public NotificationRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
