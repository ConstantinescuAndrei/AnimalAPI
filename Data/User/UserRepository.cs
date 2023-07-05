using Business.ApiResponse;
using Business.User.Repositories;
using Domain;

namespace Data.Register;

public class UserRepository : IUserRepository
{
    private readonly Context _context;

    public UserRepository(Context context) => _context = context;

    public ApiResponse<MUser> Login(MUser MUser)
    {
        var response = _context.Users!
            .FirstOrDefault(x => x.Email == MUser.Email && x.Password == MUser.Password);

        if (response != null)
        {
            return ApiResponseFactory<MUser>.MakeSuccessResponse(UserFactory.MakeModel(response));
        }

        return ApiResponseFactory<MUser>.MakeFailedResponse("Email or password is incorrect.");
    }

    public ApiResponse<MUser> Register(MUser MUser)
    {
        var response = _context.Users.FirstOrDefault(u => u.Email == MUser.Email);

        if (response != null)
        {
            return ApiResponseFactory<MUser>.MakeFailedResponse("There is already an account created with this email");
        }

        var entity = UserFactory.MakeEntity(MUser);

        _context.Users.Add(entity);
        _context.SaveChanges();

        return ApiResponseFactory<MUser>.MakeSuccessResponse(UserFactory.MakeModel(entity));
    }

    public MUser Fetch(Guid id)
    {
        var response = _context.Users.FirstOrDefault(u => u.Id == id);

        if (response == null)
        {
            return new();
        }

        return UserFactory.MakeModel(response);
    }
}