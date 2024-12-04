﻿using UserService.Models.Enum;

namespace UserService.Models.DataType
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public string Message { get; set; } = string.Empty;
        public bool Success { get; set; } = true;
        public ErrorType ErrorType { get; set; }
    }
}
