using Business.ApiResponse;
using Business.User.Repositories;
using Domain;

namespace Data.Register;

public class RegisterRepository : IRegisterRepository
{
    private readonly Context _context;

    public RegisterRepository(Context context) => _context = context;

    public ApiResponse<User> Register(User user)
    {
        var response = _context.Users.FirstOrDefault(u => u.Email == user.Email);

        if (response != null)
        {
            return ApiResponseFactory<User>.MakeFailedResponse("There is already an account created with this email");
        }

        _context.Users.Add(UserFactory.MakeEntity(user));
        _context.SaveChanges();

        return ApiResponseFactory<User>.MakeSuccessResponse(user);
    }

}