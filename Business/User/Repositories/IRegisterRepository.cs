using Business.ApiResponse;
using Domain;

namespace Business.User.Repositories;

public interface IRegisterRepository
{
   public ApiResponse<MUser> Register(MUser MUser);
}