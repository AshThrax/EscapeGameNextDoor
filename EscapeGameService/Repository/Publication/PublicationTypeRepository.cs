
namespace EscapeGameService.Repository.Publication
{
    public class PublicationTypeRepository : Repository<PublicationType>, IPublicationTypeRepository
    {
        public PublicationTypeRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
