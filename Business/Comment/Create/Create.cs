using Business.ApiResponse;
using Business.Comment.repositories;
using Domain;

namespace Business.Comment.Create;

public class Create : ICreate
{
    private readonly ICommentRepository _commentRepository;

    public Create(ICommentRepository commentRepository) => _commentRepository = commentRepository;

    public ApiResponse<List<MComment>> Execute(MComment input) => _commentRepository.Create(input);
}