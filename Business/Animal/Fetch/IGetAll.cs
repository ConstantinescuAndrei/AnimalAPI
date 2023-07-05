using Business.ApiResponse;
using Domain;

namespace Business.Animal.Fetch;

public interface IGetAll : ICommand<ApiResponse<List<MAnimal>>>
{
}