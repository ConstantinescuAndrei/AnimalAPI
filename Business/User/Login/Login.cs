using Business.ApiResponse;
using Business.User.Repositories;

namespace Business.User.Login;

public class Login : ILogin
{
    private readonly ILoginRepository _loginRepository;
    
    public Login(ILoginRepository loginRepository)
    {
        _loginRepository = loginRepository;
    }
    
    public ApiResponse<Domain.User> Execute(Domain.User input) => _loginRepository.Login(input);
}