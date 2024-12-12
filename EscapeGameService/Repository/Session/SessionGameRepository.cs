


namespace EscapeGameService.Repository.Session
{
    public class SessionGameRepository : Repository<SessionGame>, ISessionGameRepository
    {
        private readonly DataContext _dataContext;
        public SessionGameRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<DayOftheWeek> AddDayOftheWeek(DayOftheWeek dayOftheWeek)
        {
            try
            {
                DayOftheWeek DayOftheWeekdToAdd = _dataContext.DayOftheWeeks.Add(dayOftheWeek).Entity;
                _ = await _dataContext.SaveChangesAsync();
                return dayOftheWeek;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region SessionReserved
        public async Task<SessionReserved> AddSession(SessionReserved session)
        {
            try
            {
                SessionReserved sessionReservedToAdd = _dataContext.SessionReserveds.Add(session).Entity;
                _=await _dataContext.SaveChangesAsync();
                return sessionReservedToAdd;
            }
            catch (Exception)
            {

                throw;
            }
        } 
        #region Session Games
        
        public async Task<DayOftheWeek> DeleteDayofTheWeek(DayOftheWeek dayOftheWeek)
        {
            try
            {
                DayOftheWeek DayOftheWeekdToAdd = _dataContext.DayOftheWeeks.FirstOrDefaultAsync().Entity;
                _ = await _dataContext.SaveChangesAsync();
                return dayOftheWeek;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<DayOftheWeek>> GetDayOftheWeeks() => await _dataContext.DayOftheWeeks.ToListAsync();

        public IQueryable<SessionReserved> QuerySessionReserved() => _dataContext.SessionReserveds.AsNoTracking();
        public Task<DayOftheWeek> UpdateDayoftheWeek(DayOftheWeek dayOftheWeek)
        {
            throw new NotImplementedException();
        }
        #endregion
        public async Task<SessionReserved> UpdateSession(SessionReserved session)
        {
            try
            {
                SessionReserved sessionReservedToUpdate = _dataContext.SessionReserveds.Update(session).Entity;
                _ = await _dataContext.SaveChangesAsync();
                return sessionReservedToUpdate;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

    }
}
