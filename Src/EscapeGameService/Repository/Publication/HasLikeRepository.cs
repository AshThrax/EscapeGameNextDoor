
namespace EscapeGameService.Repository.Publications
{
    public class HasLikeRepository : Repository<HasLike>, IHasLikeRepository
    {
        public HasLikeRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
