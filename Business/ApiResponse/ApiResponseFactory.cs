namespace Business.ApiResponse;

public static class ApiResponseFactory<T> where T : new()
{
    public static ApiResponse<T> MakeFailedResponse(string errorMessage) => new()
    {
        Success = false,
        ErrorMessage = errorMessage,
        Data = new T()
    };

    public static ApiResponse<T> MakeSuccessResponse(T data) => new()
    {
        Success = true,
        ErrorMessage = "",
        Data = data
    };
}