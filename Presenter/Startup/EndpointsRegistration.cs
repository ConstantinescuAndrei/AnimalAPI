using Business.User.Login;
using Business.User.Register;
using Domain;

namespace Presenter.Startup;

public static class EndpointsRegistration
{
    public static IApplicationBuilder UseEndpoints(this IApplicationBuilder app)
        => app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", () => "Get");
            endpoints.MapPost("/login", (User user, ILogin login) => login.Execute(user));
            endpoints.MapPost("/register", (User user, IRegister register) => register.Execute(user));
        });
}