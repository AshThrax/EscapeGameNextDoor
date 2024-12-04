
namespace EscapeGameService.Repository.Publication
{
    public class HasLikeRepository : Repository<HasLike>, IHasLikeRepository
    {
        public HasLikeRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
