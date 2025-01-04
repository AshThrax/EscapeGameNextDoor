using EscapeGameService.Dto.ActivityType;
using EscapeGameService.Models.DataType;

namespace EscapeGameService.Services
{
    public interface IActivityPlaceService : IService<ActivityPlaces,
                                                        GetActivityPlaceDto,
                                                        AddActivityPlaceDto,
                                                        UpdateActivityPlaceDto>
    {

        /// <summary>
        /// récupération de tout les lieux d'activité selon son Type
        /// en se basant sur son id
        /// </summary>
        /// <param name="activityTypeId"></param>
        /// <returns></returns>
        Task<PaginationResponse<GetActivityPlaceDto>> GetAllFromActivityTypeId(int activityTypeId,int page, int pagesize);

        #region ActivityPlacetype
        /// <summary>
        /// lier un leiux d'activité a un type
        /// en se basant sur son id
        /// </summary>
        /// <param name="activityTypeId"></param>
        /// <returns></returns>
        Task<ServiceResponse<GetActivityPlaceTypeDto>> AddaPlaceToType(int activityId, int activityTypeId);
        /// <summary>
        /// délier un leiux d'activité a un type
        /// </summary>
        /// <param name="activityId"></param>
        /// <param name="activityTypeId"></param>
        /// <returns></returns>
        Task<ServiceResponse<GetActivityPlaceTypeDto>> RemovePlaceToType(int activityId, int activityTypeId);
        /// <summary>
        /// récupération de tout les Type d'activité existant en base de donnée 
        /// </summary>
        /// <returns></returns>
        Task<ServiceResponse<IEnumerable<GetActivityPlaceTypeDto>>> GetAllActivitytype();
        /// <summary>
        /// ajouter un nouveau type d'activitié a la base de donnée 
        /// </summary>
        /// <param name="activityType"></param>
        /// <returns></returns>
        Task<ServiceResponse<GetActivityPlaceTypeDto>> CreateActivityType(AddActivityPlaceTypeDto activityType);
        /// <summary>
        /// mise a jour d'un type d'activité present dans la base de donnée 
        /// </summary>
        /// <param name="activityType"></param>
        /// <returns></returns>
        Task<ServiceResponse<GetActivityPlaceTypeDto>> UpdateActivityType(UpdateActivityPlaceTypeDto activityType);
        /// <summary>
        /// enlever un type d'activité 
        /// </summary>
        /// <param name="activityTypeId"></param>
        /// <returns></returns>
        Task<ServiceResponse<GetActivityPlaceTypeDto>> DeleteActivityType(int activityTypeId);
        #endregion
    }

}
