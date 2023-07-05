using Business.ApiResponse;
using Business.Comment.repositories;
using Domain;

namespace Data.Comment;

public class CommentRepository : ICommentRepository
{
    private readonly Context _context;

    public CommentRepository(Context context) => _context = context;

    public ApiResponse<List<MComment>> Create(MComment comment)
    {
        _context.Comments.Add(CommentFactory.MakeEntity(comment));
        _context.SaveChanges();

        var result = _context.Comments
            .Select(CommentFactory.MakeModel)
            .ToList();

        return ApiResponseFactory<List<MComment>>.MakeSuccessResponse(result);
    }

    public List<MComment> Get(Guid imageId) => _context.Comments
        .Where(c => c.ImageId == imageId)
        .Select(CommentFactory.MakeModel)
        .ToList();
}