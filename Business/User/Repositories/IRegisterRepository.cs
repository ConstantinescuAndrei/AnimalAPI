using Business.ApiResponse;
using Domain;

namespace Business.User.Repositories;

public interface IRegisterRepository
{
   public ApiResponse<Domain.User> Register(Domain.User user);
}