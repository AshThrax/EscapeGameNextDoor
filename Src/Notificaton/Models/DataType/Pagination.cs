using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace NotificationService.Models.DataType
{
    /// <summary>
    /// this class is dedicated to pagination only 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Pagination<T>
    {
        public int Page { get; set; }
        public int PageSize { get; set; } 
        public int TotalPage { get; set; }
        public bool HasNext => Page < TotalPage;
        public bool HasPrevious =>Page > 1;
        public IList<T> Items { get; set; }

        public Pagination(List<T> items,int page, int pageSize,int totalPage) 
        {
            Items = items;
            Page = page;
            PageSize = pageSize;
            TotalPage = totalPage;
        }
        /// <summary>
        /// generate a pagination object int order to process things
        /// </summary>
        /// <param name="items"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static Pagination<T> Paginaded(List<T> items, int page, int pageSize)
        {
            if (page <= 0)
            { 
                page = 1;
            }
            if (pageSize <= 0)
            { 
                pageSize = 1;
            } 

            int Count = items.Count;
            if (Count <= 0)
            {
                return new Pagination<T>(new List<T>(),page,pageSize,0);
            }
            List<T> contentPage= items.Skip((page-1)*pageSize).Take(pageSize).ToList();
            int totalPages = (int)Math.Ceiling(Count/ (double)pageSize);

            return new Pagination<T>(items, page,pageSize, totalPages);
        }
    
    }
}
