using Business.ApiResponse;
using Domain;

namespace Business.User.Register;

public interface IRegister : ICommand<MUser, ApiResponse<MUser>>
{
}