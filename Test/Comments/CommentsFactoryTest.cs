using Data.Comment;
using Data.Comment.Entities;
using Domain;
using NUnit.Framework;
using Shouldly;

namespace Test.Comments;

public class CommentsFactoryTest
{
    private MComment _model;
    private EComment _entity;

    [SetUp]
    public void Setup()
    {
        _model = CreateModel();
        _entity = CreateEntity();
    }

    [Test]
    public void Factory_ShouldConvert_Model()
    {
        var output = CommentFactory.MakeEntity(_model);
        _entity.Id = output.Id;

        _entity.ShouldBeEquivalentTo(output);
    }

    [Test]
    public void Factory_ShouldConvert_Entity()
    {
        var output = CommentFactory.MakeModel(_entity);
        _model.Id = output.Id;

        _model.ShouldBeEquivalentTo(output);
    }

    private static MComment CreateModel() => new()
    {
       UserId = Guid.Empty,
       Message = "message",
       ImageId = Guid.Empty
    };

    private static EComment CreateEntity() => new()
    {
       UserId = Guid.Empty,
       Message = "message",
       ImageId = Guid.Empty
    };
}