
namespace EscapeGameService.Repository.Publications
{
    public class PublicationTypeRepository : Repository<PublicationType>, IPublicationTypeRepository
    {
        public PublicationTypeRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
