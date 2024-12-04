using EscapeGameService.Models.DataType;

namespace EscapeGameService.Shared
{
    public static class ErrorManager
    {
        /// <summary>
        /// Gère une réponse de service basée sur une exception ou une donnée fournie.
        /// </summary>
        public static Task<ServiceResponse<T>> ManageError<T>(Exception? exception, T? data)
        {
            if (exception != null)
                return Task.FromResult(HandleException<T>(exception));

            return Task.FromResult(data == null ? LogicError<T>() : Success(data));
        }

        /// <summary>
        /// Gère une réponse paginée avec une exception ou des données fournies.
        /// </summary>
        public static Task<PaginationResponse<T>> ManagePageErrors<T>(
            Exception? exception, IEnumerable<T>? data, int page, int pageSize, int totalCount)
        {
            if (exception != null)
                return Task.FromResult(HandlePaginationException<T>(exception));

            return Task.FromResult(data == null
                ? LogicPageError<T>()
                : SuccessPage(data, page, pageSize, totalCount));
        }

        #region Private Helpers
        private static ServiceResponse<T> HandleException<T>(Exception exception)
        {
            return exception switch
            {
                ArgumentException => BadError<T>(exception),
                NullReferenceException => NullError<T>(exception),
                _ => GenericError<T>(exception),
            };
        }

        private static PaginationResponse<T> HandlePaginationException<T>(Exception exception)
        {
            return exception switch
            {
                ArgumentException => BadPageError<T>(exception),
                NullReferenceException => NullPageError<T>(exception),
                _ => GenericPageError<T>(exception),
            };
        }
        #endregion

        #region Success Responses
        private static ServiceResponse<T> Success<T>(T data) => new()
        {
            Data = data,
            Message = "Operation successfully done.",
            ErrorType = ErrorType.Good,
            Success = true,
        };

        private static PaginationResponse<T> SuccessPage<T>(IEnumerable<T> data, int page, int pageSize, int totalCount) => new()
        {
            Data = data.ToList(),
            Page = page,
            PageSize = pageSize,
            TotalPage = totalCount,
            Message = "Operation successfully done.",
            ErrorType = ErrorType.Good,
            Success = true,
        };
        #endregion

        #region Error Responses
        private static ServiceResponse<T> BadError<T>(Exception ex) => CreateErrorResponse<T>(ex, ErrorType.Bad);
        private static ServiceResponse<T> NullError<T>(Exception ex) => CreateErrorResponse<T>(ex, ErrorType.Null);
        private static ServiceResponse<T> GenericError<T>(Exception ex) => CreateErrorResponse<T>(ex, ErrorType.Bad);

        private static PaginationResponse<T> BadPageError<T>(Exception ex) => CreatePaginationError<T>(ex, ErrorType.Bad);
        private static PaginationResponse<T> NullPageError<T>(Exception ex) => CreatePaginationError<T>(ex, ErrorType.Null);
        private static PaginationResponse<T> GenericPageError<T>(Exception ex) => CreatePaginationError<T>(ex, ErrorType.Bad);

        private static ServiceResponse<T> LogicError<T>() => new()
        {
            Message = "The operation contains logical issues.",
            ErrorType = ErrorType.Logic,
            Success = false,
        };

        private static PaginationResponse<T> LogicPageError<T>() => new()
        {
            Message = "The operation contains logical issues.",
            ErrorType = ErrorType.Logic,
            Success = false,
        };

        private static ServiceResponse<T> CreateErrorResponse<T>(Exception ex, ErrorType errorType) => new()
        {
            Data = default,
            Message = $"Exception thrown: {ex.Message}\nStackTrace: {ex.StackTrace}",
            ErrorType = errorType,
            Success = false,
        };

        private static PaginationResponse<T> CreatePaginationError<T>(Exception ex, ErrorType errorType) => new()
        {
            Data = null,
            Message = $"Exception thrown: {ex.Message}\nStackTrace: {ex.StackTrace}",
            ErrorType = errorType,
            Success = false,
        };
        #endregion
    }
}
