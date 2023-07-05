using Data.Comment.Entities;
using Domain;

namespace Data.Comment;

public static class CommentFactory
{
   public static EComment MakeEntity(MComment comment) => new()
   {
      Id = Guid.NewGuid(),
      ImageId = comment.ImageId,
      UserId = comment.UserId,
      Message = comment.Message
   };
   
   public static MComment MakeModel(EComment comment) => new()
   {
      Id = comment.Id,
      ImageId = comment.ImageId,
      UserId = comment.UserId,
      Message = comment.Message
   };
}