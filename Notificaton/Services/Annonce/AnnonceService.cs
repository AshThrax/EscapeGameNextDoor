
namespace NotificationService.Services
{
    public class AnnonceService : Service<Annonce, GetAnnonceDto, AddAnnonceDto, UpdateAnnonceDto>, IAnnonceService
    {
        public AnnonceService(IRepository<Annonce> repository, IMapper map) : base(repository, map)
        {
        }
    }
}
