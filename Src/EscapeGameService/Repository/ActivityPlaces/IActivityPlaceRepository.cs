namespace EscapeGameService.Repository;

public interface IActivityPlaceRepository: IRepository<ActivityPlaces>
{

    #region ActivityType
    Task<IEnumerable<ActivityPlacesType>> GetAllActivityType();
    Task<ActivityPlacesType> CreateTypeAsync(ActivityPlacesType activityPlaces);
    Task<ActivityPlacesType> UpdateTypeAsync(ActivityPlacesType activityPlaces);
    Task<ActivityPlacesType> DeleteAsync(ActivityPlacesType activityPlaces);
    Task<ActivityPlacesType> GetActivityType(int typeId);
    #endregion
}
