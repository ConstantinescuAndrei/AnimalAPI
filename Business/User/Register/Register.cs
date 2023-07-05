using Business.ApiResponse;
using Business.User.Repositories;
using Domain;

namespace Business.User.Register;

public class Register : IRegister
{
    private readonly IRegisterRepository _registerRepository;

    public Register(IRegisterRepository registerRepository) => _registerRepository = registerRepository;

    public ApiResponse<MUser> Execute(MUser input) => _registerRepository.Register(input);
}