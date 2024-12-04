using NotificationService.Models.DataType;

namespace NotificationService.Shared
{
    /// <summary>
    /// this class is dedicated to the Error Mananging 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class ErrorManager
    {
        /// <summary>
        /// can generate a service response base on the input you have provide
        /// </summary>
        /// <param name="exceptionType"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static async Task<ServiceResponse<T>> ManageError<T>(Exception? exceptionType, T? item)
        {
            return await Task.Run(() =>
            {
                if (exceptionType == null)
                {
                    switch (item)
                    {
                        case null:
                            return LogicError<T>();

                        default:
                            return GoodError<T>(item);
                    }

                }
                else
                {
                    switch (exceptionType)
                    {
                        case ArgumentException:
                            return BadError<T>(exceptionType);
                        case NullReferenceException:
                            return NullError<T>(exceptionType);
                        default:
                            return ClassicError<T>(exceptionType);
                    }

                }

            });
        }
        public static async Task<ServiceResponse<IEnumerable<T>>> ManageErrors<T>(Exception? exceptionType, IEnumerable<T>? item)
        {
            return await Task.Run(() =>
            {
                if (exceptionType == null)
                {
                    switch (item)
                    {
                        case null:
                            return LogicErrors<T>();

                        default:
                            return GoodErrors<T>(item);
                    }

                }
                else
                {
                    switch (exceptionType)
                    {
                        case ArgumentException:
                            return BadErrors<T>(exceptionType);
                        case NullReferenceException:
                            return NullErrors<T>(exceptionType);
                        default:
                            return ClassicErrors<T>(exceptionType);
                    }

                }

            });
        }

        public static ServiceResponse<IEnumerable<T>> GoodError<T>(IEnumerable<T>? message)
        {
            return new ServiceResponse<IEnumerable<T>>
            {
                Data = message,
                Message = "operation Sucessfully donne",
                ErrorType = Models.Enum.ErrorType.Good,
                Success = true,
            };
        }
        #region single T 
        public static ServiceResponse<T> GoodError<T>(T message)
        {
            return new ServiceResponse<T>
            {
                Data = message,
                Message = "operation Sucessfully donne",
                ErrorType = Models.Enum.ErrorType.Good,
                Success = true,
            };
        }
        public static ServiceResponse<T> BadError<T>(Exception exception)
        {
            return new ServiceResponse<T>
            {

                Message = $"operation Unsucessfully done exception throw in{exception.StackTrace} \n error message: {exception.Message}",
                ErrorType = Models.Enum.ErrorType.Bad,
                Success = false,
            };
        }
        public static ServiceResponse<T> ClassicError<T>(Exception exception)
        {
            return new ServiceResponse<T>
            {

                Message = $"operation Unsucessfully done exception throw in{exception.StackTrace} \n error message: {exception.Message}",
                ErrorType = Models.Enum.ErrorType.Bad,
                Success = false,
            };
        }
        public static ServiceResponse<T> NullError<T>(Exception exception)
        {
            return new ServiceResponse<T>
            {

                Message = $"operation returned Null in {exception.StackTrace} \n error message: {exception.Message}",
                ErrorType = Models.Enum.ErrorType.Null,
                Success = false,
            };
        }
        public static ServiceResponse<T> LogicError<T>()
        {
            return new ServiceResponse<T>
            {

                Message = "the opération containes logic issues inside It",
                ErrorType = Models.Enum.ErrorType.Logic,
                Success = false,
            };
        }
        #endregion
        #region Enumerable T
        public static ServiceResponse<IEnumerable<T>> BadErrors<T>(Exception exception)
        {
            return new ServiceResponse<IEnumerable<T>>
            {
                Data = null,
                Message = $"operation Unsucessfully done exception throw in{exception.StackTrace} \n error message: {exception.Message}",
                ErrorType = Models.Enum.ErrorType.Bad,
                Success = false,
            };
        }
        public static ServiceResponse<IEnumerable<T>> NullErrors<T>(Exception exception)
        {
            return new ServiceResponse<IEnumerable<T>>
            {

                Message = $"operation returned Null in {exception.StackTrace} \n error message: {exception.Message}",
                ErrorType = Models.Enum.ErrorType.Null,
                Success = false,
            };
        }
        public static ServiceResponse<IEnumerable<T>> ClassicErrors<T>(Exception exception)
        {
            return new ServiceResponse<IEnumerable<T>>
            {

                Message = $"operation Unsucessfully done exception throw in{exception.StackTrace} \n error message: {exception.Message}",
                ErrorType = Models.Enum.ErrorType.Bad,
                Success = false,
            };
        }
        public static ServiceResponse<IEnumerable<T>> LogicErrors<T>()
        {
            return new ServiceResponse<IEnumerable<T>>
            {

                Message = "the opération containes logic issues inside It",
                ErrorType = Models.Enum.ErrorType.Logic,
                Success = false,
            };
        }
        public static ServiceResponse<IEnumerable<T>> GoodErrors<T>(IEnumerable<T>? message)
        {
            return new ServiceResponse<IEnumerable<T>>
            {
                Data = message,
                Message = "operation Sucessfully donne",
                ErrorType = Models.Enum.ErrorType.Good,
                Success = true,
            };
        }
        #endregion
    }
}
