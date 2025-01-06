using EscapeGameService.Models;
using EscapeGameService.Repository.EscapeGame;
using Microsoft.Extensions.Logging;

namespace EscapeGameService.Repository
{
    public class EscapeRepository : Repository<Escapegame>, IEscapeRepository
    {
        private readonly DataContext _dataContext;
        public EscapeRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Event> AddEventToEscapes(Event addEvent)
        {
            try
            {
                Event EventToAdd = _dataContext.Add(addEvent).Entity;
                _=await _dataContext.SaveChangesAsync();
                return EventToAdd;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Event> DeleteEventById(int eventId)
        {
            try
            {
                Event removeEvent= await _dataContext.Events.FirstOrDefaultAsync(e => e.EventId == eventId) ?? throw new NullReferenceException("");
                _= _dataContext.Events.Remove(removeEvent);
                _= await _dataContext.SaveChangesAsync();

                return removeEvent; 

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Event>> GetAllEventByEscapesGameId(int escapeGameId)
        {
            try
            {
                return await _dataContext.Events.OrderBy(x=>x.StartDate)
                                                .Where(X=>X.EscapegameId==escapeGameId)
                                                .ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Event> GetEventById(int eventId)
        {
            try
            {
                return await _dataContext.Events.FirstOrDefaultAsync(e => e.EventId == eventId) ?? throw new NullReferenceException();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<Event> QueryEvent() => _dataContext.Events.AsNoTracking();

        public async Task<Event> UpdateEvent(Event updateEvent)
        {
            try
            {
                Event EventToUpdate= _dataContext.Events.Update(updateEvent).Entity;
                await _dataContext.SaveChangesAsync();
                return EventToUpdate;
            }
            catch (Exception)
            {

                throw;
            }
        }

      
    }
}
