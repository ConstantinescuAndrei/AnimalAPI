using Business.ApiResponse;
using Domain;

namespace Business.User.Register;

public interface IRegister : ICommand<Domain.User, ApiResponse<Domain.User>>
{
}