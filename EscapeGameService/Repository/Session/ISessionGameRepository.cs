namespace EscapeGameService.Repository.Session
{
    public interface ISessionGameRepository : IRepository<SessionGame>
    {
        #region sessionGame 
        Task<IEnumerable<DayOftheWeek>> GetDayOftheWeeks();
        Task<DayOftheWeek> AddDayOftheWeek(DayOftheWeek dayOftheWeek);
        Task<DayOftheWeek> UpdateDayoftheWeek(DayOftheWeek dayOftheWeek);
        Task<DayOftheWeek> DeleteDayofTheWeek(int id);
        #endregion

        ///
        #region SessionReserved
         
        Task<SessionReserved> AddSession(SessionReserved session);
        Task<SessionReserved> UpdateSession(SessionReserved session);
        IQueryable<SessionReserved> QuerySessionReserved();
        #endregion
    }
}
