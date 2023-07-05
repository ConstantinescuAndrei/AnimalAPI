using Business;
using Business.Animal.Create;
using Business.Animal.Fetch;
using Business.Animal.Repositories;
using Business.Comment.Fetch;
using Business.Comment.repositories;
using Business.User.Fetch;
using Business.User.Login;
using Business.User.Register;
using Business.User.Repositories;
using Data.Animal;
using Data.Comment;
using Data.Register;

namespace Presenter.Startup;

public static class BusinessRegistration
{
    public static IServiceCollection AddBusiness(this IServiceCollection services) => services
        .AddTransient<ILogin, Login>()
        .AddTransient<IRegister, Register>()
        .AddTransient<IFetch, Fetch>()
        .AddTransient<IUserRepository, UserRepository>()
        .AddTransient<ICreate, Create>()
        .AddTransient<IAnimalRepository, AnimalRepository>()
        .AddTransient<IGetAll, GetAll>()
        .AddTransient<IGetById, GetById>()
        .AddTransient<Business.Comment.Create.ICreate, Business.Comment.Create.Create>()
        .AddTransient<ICommentRepository, CommentRepository>()
        .AddTransient<IGetComments, GetComments>();
}