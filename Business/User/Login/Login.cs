using Business.ApiResponse;
using Business.User.Repositories;
using Domain;

namespace Business.User.Login;

public class Login : ILogin
{
    private readonly ILoginRepository _loginRepository;
    
    public Login(ILoginRepository loginRepository)
    {
        _loginRepository = loginRepository;
    }
    
    public ApiResponse<MUser> Execute(MUser input) => _loginRepository.Login(input);
}