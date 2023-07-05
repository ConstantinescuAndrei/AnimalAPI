using Business.ApiResponse;
using Business.User.Repositories;
using Domain;

namespace Business.User.Register;

public class Register : IRegister
{
    private readonly IUserRepository _userRepository;

    public Register(IUserRepository userRepository) => _userRepository = userRepository;

    public ApiResponse<MUser> Execute(MUser input) => _userRepository.Register(input);
}