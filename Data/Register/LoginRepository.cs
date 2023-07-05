using Business.ApiResponse;
using Business.User.Repositories;
using Domain;

namespace Data.Register;

public class LoginRepository : ILoginRepository
{
    private readonly Context _context;

    public LoginRepository(Context context) => _context = context;
    
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
}