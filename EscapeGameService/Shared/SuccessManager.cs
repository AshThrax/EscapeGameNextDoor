using EscapeGameService.Models.DataType;

namespace EscapeGameService.Shared
{
    public static class SuccessManager
    {
        public static async Task<ServiceResponse<T>> SuccessResponse<T>(T entity)
        {
           return await Task.Run(() =>
            {
               return new ServiceResponse<T>
                {
                    ErrorType = ErrorType.Good,
                    Data = entity,
                    Message = "operation SucessFull",
                    Success = true
                };

            });
        }

        public static async Task<PaginationResponse<T>> SuccessResponse<T>(PaginationBuilder<T> entity)
        {
            return await Task.Run(() =>
            {
                return new PaginationResponse<T>
                {
                    ErrorType = ErrorType.Good,
                    Data = entity.Data,
                    Page = entity.Page,
                    PageSize = entity.PageSize,
                    TotalPage = entity.TotalPage,
                    Message = "operation SucessFull",
                    Success = true
                };

            });
        }
    }
}
