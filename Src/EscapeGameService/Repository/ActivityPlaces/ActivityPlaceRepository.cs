

using System;

namespace EscapeGameService.Repository;

public class ActivityPlaceRepository : Repository<ActivityPlaces>, IActivityPlaceRepository
{
    private readonly DataContext _dataContext;
    public ActivityPlaceRepository(DataContext dataContext) : base(dataContext)
    {
        _dataContext = dataContext;
    }

    #region Type
        public async Task<ActivityPlacesType> CreateTypeAsync(ActivityPlacesType activityPlaces)
        {
            try
            {
                ActivityPlacesType activityPlacesType = _dataContext.ActivityPlacesTypes.Add(activityPlaces).Entity;
                await _dataContext.SaveChangesAsync();
                return activityPlacesType;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ActivityPlacesType> DeleteAsync(ActivityPlacesType activityPlaces)
        {
            try
            {
                ActivityPlacesType activityPlacesType = _dataContext.ActivityPlacesTypes.Remove(activityPlaces).Entity;
                await _dataContext.SaveChangesAsync();
                return activityPlacesType;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ActivityPlacesType> GetActivityType(int typeId)
        {
            try
            {
                return await _dataContext.ActivityPlacesTypes.FirstOrDefaultAsync(x => x.Id==typeId) ?? throw new NullReferenceException("no reference of the object found");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<ActivityPlacesType>> GetAllActivityType()
        {
            try
            {
                return await _dataContext.ActivityPlacesTypes.ToListAsync() ?? throw new NullReferenceException("no reference of the object found");

            }
        catch (Exception)
            {

                throw;
            }
        }

        public async Task<ActivityPlacesType> UpdateTypeAsync(ActivityPlacesType activityPlaces)
        {
            try
            {
                ActivityPlacesType update_entity= _dataContext.ActivityPlacesTypes.Update(activityPlaces).Entity ?? throw new NullReferenceException("no reference of the object found");
                await _dataContext.SaveChangesAsync();
                return update_entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

    #endregion

    #region Activity

    #endregion
}
