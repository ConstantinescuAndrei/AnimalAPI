using Business.ApiResponse;
using Domain;

namespace Business.Comment.Create;

public interface ICreate : ICommand<MComment, ApiResponse<List<MComment>>>
{
}