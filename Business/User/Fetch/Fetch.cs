using Business.User.Repositories;
using Domain;

namespace Business.User.Fetch;

public class Fetch : IFetch
{
    private readonly IUserRepository _userRepository;

    public Fetch(IUserRepository userRepository) => _userRepository = userRepository;

    public MUser Execute(Guid input) => _userRepository.Fetch(input);
}