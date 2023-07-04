using Data.Register.Entities;
using Domain;

namespace Data.Register;

public static class UserFactory
{
    public static User MakeModel(EUser entity) => new()
    {
        Id = entity.Id,
        Username = entity.Username,
        Email = entity.Email
    };

    public static EUser MakeEntity(User model) => new()
    {
        Id = Guid.NewGuid(),
        Username = model.Username,
        Email = model.Email,
        Password = model.Password
    };
}