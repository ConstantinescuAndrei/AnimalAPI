using Business.ApiResponse;

namespace Business.User.Login;

public interface ILogin : ICommand<Domain.User, ApiResponse<Domain.User>>
{
}