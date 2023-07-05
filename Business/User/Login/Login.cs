using Business.ApiResponse;
using Business.User.Repositories;
using Domain;

namespace Business.User.Login;

public class Login : ILogin
{
    private readonly IUserRepository _userRepository;
    
    public Login(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public ApiResponse<MUser> Execute(MUser input) => _userRepository.Login(input);
}