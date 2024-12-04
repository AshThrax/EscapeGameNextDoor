using EscapeGameService.Dto.Base;
using EscapeGameService.Models.DataType;

namespace EscapeGameService.Services
{
    public interface IService<TIn, TOut, TAdd, TUp>
        where TIn : class
        where TOut : BaseDto
        where TAdd : AddDto
        where TUp : UpdateDto
    {
        /// <summary>
        /// get an entity base on his id 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<ServiceResponse<TOut>> GetById(int Id);
        /// <summary>
        /// get all the entity
        /// </summary>
        /// <returns></returns>
        Task<ServiceResponse<IEnumerable<TOut>>> GetAll();
        /// <summary>
        /// get all by pagination
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<PaginationResponse<TOut>> GetAllPage(int page, int pageSize);
        /// <summary>
        /// Create a new entity
        /// </summary>
        /// <param name="addDTo"></param>
        /// <returns></returns>
        Task<ServiceResponse<TOut>> Create(TAdd addDTo);
        /// <summary>
        /// Update an existing entityt
        /// </summary>
        /// <param name="updateDto"></param>
        /// <returns></returns>
        Task<ServiceResponse<TOut>> Update(TUp updateDto);
        /// <summary>
        /// delete an entity from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ServiceResponse<TOut>> Delete(int id);
    }
}
