using Business.ApiResponse;
using Domain;

namespace Business.User.Login;

public interface ILogin : ICommand<MUser, ApiResponse<MUser>>
{
}