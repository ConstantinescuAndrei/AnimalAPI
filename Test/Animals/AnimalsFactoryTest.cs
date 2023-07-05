using Data.Animal;
using Data.Animal.Entities;
using Domain;
using NUnit.Framework;
using Shouldly;

namespace Test.Animals;

public class AnimalsFactoryTest
{
    private MAnimal _model;
    private EAnimal _entity;

    [SetUp]
    public void Setup()
    {
        _model = CreateModel();
        _entity = CreateEntity();
    }

    [Test]
    public void Factory_ShouldConvert_Model()
    {
        var output = AnimalFactory.MakeEntity(_model);
        _entity.Id = output.Id;

        _entity.ShouldBeEquivalentTo(output);
    }

    [Test]
    public void Factory_ShouldConvert_Entity()
    {
        var output = AnimalFactory.MakeModel(_entity);
        _model.Id = output.Id;

        _model.ShouldBeEquivalentTo(output);
    }

    private static MAnimal CreateModel() => new()
    {
        Color = "white",
        Race = "Husky",
        ImageUrl = "url",
        UserId = Guid.Empty,
    };

    private static EAnimal CreateEntity() => new()
    {
        Color = "white",
        Race = "Husky",
        ImageUrl = "url",
        UserId = Guid.Empty,
    };
}