
using EscapeGameService.Models.DataType;
using System.Linq.Expressions;
using System.Security.Principal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EscapeGameService.Repository
{
    public class Repository<T> :IRepository<T> where T : class
    {
        private readonly DataContext _dataContext;
        private readonly DbSet<T> _dbSet;

        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
            _dbSet = dataContext.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
           
            try
            {
                T addEntity =_dbSet.Add(entity).Entity;
                await _dataContext.SaveChangesAsync();
                return addEntity;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public IQueryable<T> Query()=>_dataContext.Set<T>().AsNoTracking();
        public async Task<T> DeleteAsync(int id)
        {
            try
            {
                T dataToDelete= await _dbSet.FindAsync(id) ?? throw new NullReferenceException();
                if (dataToDelete == null)
                {
                    throw new NullReferenceException();
                }
             
                 _dataContext.Entry(dataToDelete).State = EntityState.Deleted;
                 await _dataContext.SaveChangesAsync();
                 return dataToDelete;
            }
            catch (Exception ex)
            {

                throw;
            }
        
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
          
            try
            {
                IEnumerable<T> data = await _dbSet.ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                throw;
            }
          
        }
        public async Task<IEnumerable<T>> GetByPage(int page, int pageSize) 
        {
            try
            {
                try
                {
                    return await _dbSet.Skip((page-1)*pageSize)
                                                      .Take(pageSize)
                                                      .ToListAsync();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<T> GetById(int Id)
        {
           
            try
            {
                T? data= await _dbSet.FindAsync(Id);
                return data ;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public async Task<IEnumerable<T>> GetFiltered(Expression<Func<T, bool>> predicate)
        {
           
            try
            {
                IQueryable<T> query = _dbSet;
                if (predicate != null)
                {
                    query = _dbSet.Where(predicate);
                }
                IEnumerable<T> result = await query.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
          
            try
            {
                var datatoUpdate=_dbSet.Update(entity).Entity;
                await _dataContext.SaveChangesAsync();
                return datatoUpdate;
            }
            catch (Exception ex)
            {

                throw;
            }
         
        }

        public async Task<IEnumerable<T>> GetFiltered(Expression<Func<T, bool>> predicate, int page, int pageSize)
        {
            try
            {
                IQueryable<T> query = _dbSet;
                if (predicate != null)
                {
                    query = _dbSet.Where(predicate);
                }
                IEnumerable<T> result = await query.Skip((page-1)*pageSize).Take(pageSize).ToListAsync();
                return result;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<int> CountAsync()
        {
            try
            {
                int result = await _dbSet.CountAsync();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                IQueryable<T> query = _dbSet;
                if (predicate != null)
                {
                    query = _dbSet.Where(predicate);
                }
                int result = await query.CountAsync();
                return result;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
