using Business.ApiResponse;
using Business.User.Repositories;

namespace Business.User.Register;

public class Register : IRegister
{
    private readonly IRegisterRepository _registerRepository;

    public Register(IRegisterRepository registerRepository) => _registerRepository = registerRepository;

    public ApiResponse<Domain.User> Execute(Domain.User input) => _registerRepository.Register(input);
}