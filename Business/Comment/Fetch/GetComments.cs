using Business.ApiResponse;
using Business.Comment.repositories;
using Business.User.Fetch;
using Domain;

namespace Business.Comment.Fetch;

public class GetComments : IGetComments
{
    private readonly ICommentRepository _commentRepository;
    private readonly IFetch _fetchUser;

    public GetComments(ICommentRepository commentRepository, IFetch fetchUser)
    {
        _commentRepository = commentRepository;
        _fetchUser = fetchUser;
    }

    public ApiResponse<List<Tuple<MComment, MUser>>> Execute(Guid input)
    {
        var comments = _commentRepository.Get(input);
        var result = new List<Tuple<MComment, MUser>>();
        
        foreach (var comment in comments)
        {
            var userInfo = _fetchUser.Execute(comment.UserId);

            result.Add(new Tuple<MComment, MUser>(comment, userInfo));
        }

        return ApiResponseFactory<List<Tuple<MComment, MUser>>>.MakeSuccessResponse(result);
    }
}