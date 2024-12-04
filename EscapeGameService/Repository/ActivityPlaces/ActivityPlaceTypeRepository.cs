
namespace EscapeGameService.Repository;
public class ActivityPlaceTypeRepository : Repository<ActivityPlacesType>, IActivityPlaceTypeRepository
{
    public ActivityPlaceTypeRepository(DataContext dataContext) : base(dataContext)
    {
    }
}

