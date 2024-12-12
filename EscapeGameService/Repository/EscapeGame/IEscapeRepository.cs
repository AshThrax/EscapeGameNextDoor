

namespace EscapeGameService.Repository.EscapeGame
{
    public interface IEscapeRepository : IRepository<Escapegame>
    {
        #region EscapeGame
        #endregion

        #region Event
        /// <summary>
        /// récupère un type se lieux d'activité basé sur son id 
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<IEnumerable<Event>> GetAllEventByEscapesGameId(int escapeGameId);
        /// <summary>
        /// récupère un type se lieux d'activité basé sur son id 
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<Event> GetEventById(int eventId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="addEvent"></param>
        /// <returns></returns>
        Task<Event> AddEventToEscapes(Event addEvent);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="updateEvent"></param>
        /// <returns></returns>
        Task<Event>UpdateEvent(Event updateEvent);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        Task<Event> DeleteEventById(int eventId);

        IQueryable<Event> QueryEvent();
        #endregion

        #region Session

        #endregion
    }
}
