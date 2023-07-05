using Business.ApiResponse;
using Domain;

namespace Business.User.Repositories;

public interface IUserRepository
{
    public ApiResponse<MUser> Login(MUser MUser);

    public ApiResponse<MUser> Register(MUser MUser);

    public MUser Fetch(Guid id);
}