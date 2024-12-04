

namespace EscapeGameService.Repository.EscapeGame
{
    public interface IEscapeRepository : IRepository<Escapegame>
    {
        #region EscapeGame
        #endregion

        #region Activity
        /// <summary>
        /// ajoute une entité de type Activity place a un escapesgame
        /// </summary>
        /// <param name="AddActivity"></param>
        /// <returns></returns>
        Task<ActivityPlaces> AddActivityPlaceToEscapeGame(ActivityPlaces AddActivity);
        /// <summary>
        /// enlève une entité activity place
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <param name="activityId"></param>
        /// <returns></returns>
        Task<ActivityPlaces> RemoveActivityFromEscapeGame(int escapesGameId, int activityId);
        /// <summary>
        /// récupérer tout les entité Activityplace lier a un escapes games
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<IEnumerable<ActivityPlaces>> GetAllActivityPlace(int escapesGameId);
        /// <summary>
        /// récupérer tout les leix D'activité basé sur l'id du ActivityTypeId
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<IEnumerable<ActivityPlaces>> GetAllActivityPlacByActivityId(int activityTypeId);
        /// <summary>
        /// récu^ére un lieu d'activité basé sur son id
        /// </summary>
        /// <param name="activityId"></param>
        /// <returns></returns>
        Task<ActivityPlaces> GetActivityById(int activityId);
        #endregion

        #region ActivityPlaceType
        /// <summary>
        /// récupère tout les lieux d'activité presente sur l'application
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<List<ActivityPlacesType>> GetAllActivityPlaceType(int escapesGameId);
        /// <summary>
        /// récupère un type se lieux d'activité basé sur son id 
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<ActivityPlacesType> GetActivityPlaceTypeById(int ActivityplaceId);
        /// <summary>
        /// récupère tout les lieux d'activité presente sur l'application
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<ActivityPlacesType> CreateActivityPlaceType(int escapesGameId);
        /// <summary>
        /// récupère un type se lieux d'activité basé sur son id 
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<ActivityPlacesType> UpdateActivityPlaceType(int ActivityplaceId);
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
        Task<IEnumerable<Event>> GetEventById(int eventId);
        #endregion
    }
}
