using Business.ApiResponse;
using Domain;

namespace Business.Comment.Fetch;

public interface IGetComments : ICommand<Guid, ApiResponse<List<Tuple<MComment, MUser>>>>
{
}