using Data.Register;
using Data.Register.Entities;
using Domain;
using NUnit.Framework;
using Shouldly;

namespace Test.Users;

public class UserFactoryTest
{
    private MUser _model;
    private EUser _entity;

    [SetUp]
    public void Setup()
    {
        _model = CreateModel();
        _entity = CreateEntity();
    }

    [Test]
    public void Factory_ShouldConvert_Model()
    {
        var output = UserFactory.MakeEntity(_model);
        _entity.Id = output.Id;

        _entity.ShouldBeEquivalentTo(output);
    }

    [Test]
    public void Factory_ShouldConvert_Entity()
    {
        var output = UserFactory.MakeModel(_entity);
        var model = new MUser()
        {
            Id = output.Id,
            Email = "email@email.com",
            Username = "username"
        };

        model.ShouldBeEquivalentTo(output);
    }

    private static MUser CreateModel() => new()
    {
        Email = "email@email.com",
        Password = "password",
        Username = "username"
    };

    private static EUser CreateEntity() => new()
    {
        Email = "email@email.com",
        Password = "password",
        Username = "username"
    };
}