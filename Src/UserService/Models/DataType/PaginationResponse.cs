using UserService.Models.Enum;

namespace UserService.Models.DataType
{
    public class PaginationResponse<T>
    {
        public List<T>? Data { get; set; }
        public int Page { get; set; }
        public string Message { get; set; } = string.Empty;
        public bool Success { get; set; } = true;
        public ErrorType ErrorType { get; set; }
    }
}
