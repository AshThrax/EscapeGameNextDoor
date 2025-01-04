using EscapeGameService.Repository.Publications;

namespace EscapeGameService.Repository.Publications
{
    public class PublicationRepository : Repository<Publication>, IPublicationRepository
    {
        public PublicationRepository(DataContext dataContext) : base(dataContext)
        {

        }

        #region 
        #endregion
    }
}
