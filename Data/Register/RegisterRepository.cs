using Business.ApiResponse;
using Business.User.Repositories;
using Domain;

namespace Data.Register;

public class RegisterRepository : IRegisterRepository
{
    private readonly Context _context;

    public RegisterRepository(Context context) => _context = context;

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

}