
using AutoMapper;
using EscapeGameService.Dto.Base;
using EscapeGameService.Models.DataType;
using System.Security.Principal;

namespace EscapeGameService.Services
{
    public class Service<TIn, TOut, TAdd, TUp> : IService<TIn, TOut, TAdd, TUp>
        where TIn : class
        where TOut: BaseDto
        where TAdd: AddDto
        where TUp : UpdateDto
    {

        private readonly IRepository<TIn> _repository;
        private readonly IMapper _map;

        public Service(IRepository<TIn> repository, IMapper map)
        {
            _repository = repository;
            _map = map;
        }

        public virtual async Task<ServiceResponse<TOut>> Create(TAdd addDto)
        {
            try
            {
                TIn create_entity = _map.Map<TIn>(addDto);
                create_entity = await _repository.CreateAsync(create_entity);

                return await ErrorManager.ManageError(null,_map.Map<TOut>(create_entity));
            }
            catch (Exception exception)
            {
                return await ErrorManager.ManageError<TOut>(exception, null);
            }
        }

        public virtual async Task<ServiceResponse<IEnumerable<TOut>>> GetAll()
        {
            try
            {
                IEnumerable<TIn> getAll = await _repository.GetAllAsync();
                return await ErrorManager.ManageError(null, _map.Map<IEnumerable<TOut>>(getAll));
            }
            catch (Exception exception)
            {
                return await ErrorManager.ManageError<IEnumerable<TOut>>(exception,null);
            }
        }

        public virtual async Task<PaginationResponse<TOut>> GetAllPage(int page, int pageSize)
        {
            try
            {
                int totalpage,TotalCount;

                if (pageSize < 0) 
                {
                    throw new ArgumentOutOfRangeException(nameof(pageSize));
                }

                if (page <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(page));
                }
                TotalCount = await _repository.CountAsync();

                totalpage=(int)Math.Ceiling((double)(TotalCount/pageSize));

                if (totalpage < 0)
                {
                    throw new InvalidOperationException("");
                }

                IEnumerable<TIn> getPageFromRequest= await _repository.GetByPage(page,pageSize);

                return await ErrorManager.ManagePageErrors(null,_map.Map<IEnumerable<TOut>>(getPageFromRequest),page,pageSize,totalpage);
            }
            catch (Exception exception)
            {
                return await ErrorManager.ManagePageErrors(exception, new List<TOut>(), page, pageSize, 0);
            }
        }

        public virtual async Task<ServiceResponse<TOut>> GetById(int Id)
        {

            try
            {
                TIn reporesponse = await _repository.GetById(Id);
                return await ErrorManager.ManageError(null,_map.Map<TOut>(reporesponse));
            }
            catch (Exception exception)
            {
                return await ErrorManager.ManageError<TOut>(exception, null);
            }
        }

        public virtual async Task<ServiceResponse<TOut>> Update(TUp updateDto)
        {
            try
            {
                TIn update_entity = _map.Map<TIn>(updateDto);
                update_entity = await _repository.UpdateAsync(update_entity);
                return await ErrorManager.ManageError(null, _map.Map<TOut>(update_entity));
            }
            catch (Exception exception)
            {
                return await ErrorManager.ManageError<TOut>(exception, null);
            }
        }
        public virtual async Task<ServiceResponse<TOut>> Delete(int id)
        {
            try
            {
                return _map.Map<ServiceResponse<TOut>>(await _repository.DeleteAsync(id));
            }
            catch (Exception exception)
            {
                return await ErrorManager.ManageError<TOut>(exception, null);
            }
        }
    }
}
