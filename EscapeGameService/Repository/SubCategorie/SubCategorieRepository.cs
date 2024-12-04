
namespace EscapeGameService.Repository;

public class SubCategorieRepository : Repository<SubCategorie>, ISubCategorieRepository
{
    public SubCategorieRepository(DataContext dataContext) : base(dataContext)
    {
    }
}

