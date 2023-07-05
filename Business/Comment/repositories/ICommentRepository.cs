using Business.ApiResponse;
using Domain;

namespace Business.Comment.repositories;

public interface ICommentRepository
{
    public ApiResponse<List<MComment>> Create(MComment comment);

    public List<MComment> Get(Guid imageId);
}