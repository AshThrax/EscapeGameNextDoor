
namespace EscapeGameService.Repository
{
    public class CategorieRepository : Repository<Categorie>, ICategorieRepository
    {
        public CategorieRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
