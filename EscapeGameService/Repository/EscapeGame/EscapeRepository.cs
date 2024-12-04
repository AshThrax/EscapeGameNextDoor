using EscapeGameService.Repository.EscapeGame;

namespace EscapeGameService.Repository
{
    public class EscapeRepository : Repository<Escapegame>, IEscapeRepository
    {
        public EscapeRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public Task<ActivityPlaces> AddActivityPlaceToEscapeGame(ActivityPlaces AddActivity)
        {
            throw new NotImplementedException();
        }

        public Task<ActivityPlacesType> CreateActivityPlaceType(int escapesGameId)
        {
            throw new NotImplementedException();
        }

        public Task<ActivityPlaces> GetActivityById(int activityId)
        {
            throw new NotImplementedException();
        }

        public Task<ActivityPlacesType> GetActivityPlaceTypeById(int ActivityplaceId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ActivityPlaces>> GetAllActivityPlacByActivityId(int activityTypeId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ActivityPlaces>> GetAllActivityPlace(int escapesGameId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ActivityPlacesType>> GetAllActivityPlaceType(int escapesGameId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Event>> GetAllEventByEscapesGameId(int escapeGameId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Event>> GetEventById(int eventId)
        {
            throw new NotImplementedException();
        }

        public Task<ActivityPlaces> RemoveActivityFromEscapeGame(int escapesGameId, int activityId)
        {
            throw new NotImplementedException();
        }

        public Task<ActivityPlacesType> UpdateActivityPlaceType(int ActivityplaceId)
        {
            throw new NotImplementedException();
        }
    }
}
