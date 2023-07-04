using Business.ApiResponse;
using Business.User.Repositories;
using Domain;

namespace Data.Register;

public class LoginRepository : ILoginRepository
{
    private readonly Context _context;

    public LoginRepository(Context context) => _context = context;
    
    public ApiResponse<User> Login(User user)
    {
        var response = _context.Users!
            .FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);

        if (response != null)
        {
            return ApiResponseFactory<User>.MakeSuccessResponse(user);
        }

        return ApiResponseFactory<User>.MakeFailedResponse("Email or password is incorrect.");
    }
}