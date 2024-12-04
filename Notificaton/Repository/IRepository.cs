using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using NotificationService.Models.DataType;
using System.Linq.Expressions;

namespace NotificationService.Repository
{
        public interface IRepository<T> where T : class
        {
            /// <summary>
            /// create Entity async 
            /// </summary>
            /// <param name="entity"></param>
            /// <returns></returns>
            Task<T> CreateAsync(T entity);
            /// <summary>
            /// update async entities
            /// </summary>
            /// <param name="entity"></param>
            /// <returns></returns>
            Task<T> UpdateAsync(T entity);
            /// <summary>
            /// delete async entities
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            Task<T> DeleteAsync(int id);
            /// <summary>
            /// filtered entities base ona predicate
            /// </summary>
            /// <param name="predicate"></param>
            /// <returns></returns>
            Task<IEnumerable<T>> GetFiltered(Expression<Func<T, bool>> predicate, int page, int pageSize);
            /// <summary>
            /// filtered entities base ona predicate
            /// </summary>
            /// <param name="predicate"></param>
            /// <returns></returns>
            Task<IEnumerable<T>> GetByPage(int page, int pageSize);
            /// <summary>
            /// get all async entities
            /// </summary>
            /// <returns></returns>
            Task<IEnumerable<T>> GetAllAsync();
            /// <summary>
            /// get entities By ids
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            Task<T> GetById(int Id);
        }
}
