
using AutoMapper;
using EscapeGameService.Dto.ActivityType;
using EscapeGameService.Models;
using EscapeGameService.Models.DataType;
using System;

namespace EscapeGameService.Services;

public class ActivityPlaceService : Service<ActivityPlaces, 
                                            GetActivityPlaceDto,
                                            AddActivityPlaceDto,
                                            UpdateActivityPlaceDto>,
                                            IActivityPlaceService
{
    private readonly IMapper _map;
    private readonly IActivityPlaceRepository _repository;
    public ActivityPlaceService(IActivityPlaceRepository repository, IMapper map) : base(repository, map)
    {
        _repository= repository;
        _map = map; 
    }

    #region ActivityPlacetype
    public async Task<ServiceResponse<GetActivityPlaceTypeDto>> CreateActivityType(AddActivityPlaceTypeDto activityType)
    {
        try
        {
            try
            {
                ActivityPlacesType create_entity = _map.Map<ActivityPlacesType>(activityType);
                create_entity = await _repository.CreateTypeAsync(create_entity);

                return await ErrorManager.ManageError(null, _map.Map<GetActivityPlaceTypeDto>(create_entity));
            }
            catch (Exception exception)
            {
                return await ErrorManager.ManageError<GetActivityPlaceTypeDto>(exception, null);
            }
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<ServiceResponse<GetActivityPlaceTypeDto>> DeleteActivityType(int activityTypeId)
    {

        try
        {
            ActivityPlacesType remove_entity = await _repository.GetActivityType (activityTypeId);
            remove_entity = await _repository.DeleteAsync(remove_entity);

            return await ErrorManager.ManageError(null, _map.Map<GetActivityPlaceTypeDto>(remove_entity));
        }
        catch (Exception exception)
        {

            return await ErrorManager.ManageError<GetActivityPlaceTypeDto>(exception, null);
        }
    }

    public async Task<ServiceResponse<IEnumerable<GetActivityPlaceTypeDto>>> GetAllActivitytype()
    {

        try
        {
            IEnumerable<ActivityPlacesType> retrieve_Allentity = await _repository.GetAllActivityType();
            return await ErrorManager.ManageError(null, _map.Map<IEnumerable<GetActivityPlaceTypeDto>>(retrieve_Allentity));
        }
        catch (Exception exception)
        {

            return await ErrorManager.ManageError<IEnumerable<GetActivityPlaceTypeDto>>(exception, null);
        }
    }

    public async Task<PaginationResponse<GetActivityPlaceDto>> GetAllFromActivityTypeId(int activityTypeId,int page ,int pageSize)
    {

        try
        {
            int totalpage, TotalCount;

            if (pageSize < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pageSize));
            }

            if (page <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(page));
            }
            TotalCount = await _repository.CountAsync(x=>x.ActivityId==activityTypeId);

            totalpage = (int)Math.Ceiling((double)(TotalCount / pageSize));

            if (totalpage < 0)
            {
                throw new InvalidOperationException("");
            }

            IEnumerable<ActivityPlaces> getPageFromRequest = await _repository.GetFiltered(c=>c.ActivityType.Id==activityTypeId,page, pageSize);

            return await ErrorManager.ManagePageErrors(null, _map.Map<IEnumerable<GetActivityPlaceDto>>(getPageFromRequest), page, pageSize, totalpage);
        }
        catch (Exception exception)
        {

            return await ErrorManager.ManagePageErrors<GetActivityPlaceDto>(exception, null,page,pageSize,0);
        }
    }

    public async Task<ServiceResponse<GetActivityPlaceTypeDto>> UpdateActivityType(UpdateActivityPlaceTypeDto activityType)
    {

        try
        {
            ActivityPlacesType update_entity = await _repository.GetActivityType(activityType.Id);
            update_entity.Name = activityType.Name;
            update_entity = await _repository.UpdateTypeAsync(update_entity);
            return await ErrorManager.ManageError(null, _map.Map<GetActivityPlaceTypeDto>(update_entity));
        }
        catch (Exception exception)
        {

            return await ErrorManager.ManageError<GetActivityPlaceTypeDto>(exception, null);
        }
    }
    public async Task<ServiceResponse<GetActivityPlaceTypeDto>> AddaPlaceToType(int activityId, int activityTypeId) 
    {
        
        try
        {
            ActivityPlaces linkentity = await _repository.GetById(activityId);
            linkentity.ActivityType= await _repository.GetActivityType(activityTypeId);
            linkentity = await _repository.UpdateAsync(linkentity);
            return await ErrorManager.ManageError(null, _map.Map<GetActivityPlaceTypeDto>(linkentity));
        }
        catch (Exception exception)
        {

            return await ErrorManager.ManageError<GetActivityPlaceTypeDto>(exception, null);
        }
    }
    public async Task<ServiceResponse<GetActivityPlaceTypeDto>> RemovePlaceToType(int activityId, int activityTypeId)
    {

        try
        {
            ActivityPlaces linkentity = await _repository.GetById(activityId);
            linkentity.ActivityType = null;
            linkentity = await _repository.UpdateAsync(linkentity);
            return await ErrorManager.ManageError(null, _map.Map<GetActivityPlaceTypeDto>(linkentity));
        }
        catch (Exception exception)
        {

            return await ErrorManager.ManageError<GetActivityPlaceTypeDto>(exception, null);
        }
    }


    #endregion
}
