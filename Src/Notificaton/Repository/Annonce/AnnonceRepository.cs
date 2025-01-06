using NotificationService.Data;
using NotificationService.Models;

namespace NotificationService.Repository
{
    public class AnnonceRepository : Repository<Annonce>, IAnnonceRepository
    {
        public AnnonceRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
