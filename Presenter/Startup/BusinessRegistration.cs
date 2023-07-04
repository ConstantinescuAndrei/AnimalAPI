using Business.User.Login;
using Business.User.Register;
using Business.User.Repositories;
using Data.Register;

namespace Presenter.Startup;

public static class BusinessRegistration
{
    public static IServiceCollection AddBusiness(this IServiceCollection services) => services
        .AddTransient<ILogin, Login>()
        .AddTransient<ILoginRepository, LoginRepository>()
        .AddTransient<IRegister, Register>()
        .AddTransient<IRegisterRepository, RegisterRepository>();
}