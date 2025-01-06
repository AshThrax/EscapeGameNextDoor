using NotificationService.Dto.Base;

namespace NotificationService.Services
{
    public class Service<TIn, TOut, TAdd, TUp> : IService<TIn, TOut, TAdd, TUp>
        where TIn : class
        where TOut : BaseDto
        where TAdd : AddDto
        where TUp : UpdateDto
    {
        private readonly IRepository<TIn> _repository;
        private readonly IMapper _map;

        public Service(IRepository<TIn> repository, IMapper map)
        {
            _repository = repository;
            _map = map;
        }

        public async Task<ServiceResponse<TOut>> Create(TAdd addDto)
        {
            try
            {
                TIn create_entity = _map.Map<TIn>(addDto);
                create_entity = await _repository.CreateAsync(create_entity);

                return await ErrorManager.ManageError(null, _map.Map<TOut>(create_entity));
            }
            catch (Exception exception)
            {
                return await ErrorManager.ManageError<TOut>(exception, null);
            }
        }

        public async Task<ServiceResponse<IEnumerable<TOut>>> GetAll()
        {
            try
            {
                IEnumerable<TIn> getAll = await _repository.GetAllAsync();
                return await ErrorManager.ManageErrors(null, _map.Map<IEnumerable<TOut>>(getAll));
            }
            catch (Exception exception)
            {
                return await ErrorManager.ManageErrors<TOut>(exception, null);
            }
        }

        public async Task<ServiceResponse<IEnumerable<TOut>>> GetAllPage(int page, int pageSize)
        {
            try
            {
                IEnumerable<TIn> getPageFromRequest = await _repository.GetByPage(page, pageSize);

                return await ErrorManager.ManageErrors(null, _map.Map<IEnumerable<TOut>>(getPageFromRequest));
            }
            catch (Exception exception)
            {
                return await ErrorManager.ManageErrors(exception, new List<TOut>());
            }
        }

        public async Task<ServiceResponse<TOut>> GetById(int Id)
        {

            try
            {
                TIn reporesponse = await _repository.GetById(Id);
                return await ErrorManager.ManageError(null, _map.Map<TOut>(reporesponse));
            }
            catch (Exception exception)
            {
                return await ErrorManager.ManageError<TOut>(exception, null);
            }
        }

        public async Task<ServiceResponse<TOut>> Update(TUp updateDto)
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
        public async Task<ServiceResponse<TOut>> Delete(int id)
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
