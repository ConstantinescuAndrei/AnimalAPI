using Business.ApiResponse;
using Domain;

namespace Business.User.Repositories;

public interface ILoginRepository
{
    public ApiResponse<MUser> Login(MUser MUser);
}