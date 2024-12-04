interface ServiceResponse<T>
{
    Data: T;
    Message: string;
    Succsess: boolean;
    ErrorType: ErrorType
}

enum ErrorType
{
    Good,Bad,Null,logic
}