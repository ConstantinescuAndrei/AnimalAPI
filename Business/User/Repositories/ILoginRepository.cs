using Business.ApiResponse;

namespace Business.User.Repositories;

public interface ILoginRepository
{
    public ApiResponse<Domain.User> Login(Domain.User user);
}