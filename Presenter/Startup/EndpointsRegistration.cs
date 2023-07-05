using Business.Animal.Create;
using Business.Animal.Fetch;
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
            endpoints.MapPost("/login", (MUser user, ILogin login) => login.Execute(user));
            endpoints.MapPost("/register", (MUser user, IRegister register) => register.Execute(user));
            endpoints.MapPost("/animals/create", (MAnimal animal, ICreate create) => create.Execute(animal));
            endpoints.MapGet("/animals", (IGetAll getAll) => getAll.Execute());
            endpoints.MapGet("/animals/{id}", (Guid id, IGetById getById) => getById.Execute(id));
        });
}