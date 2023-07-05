using Business.ApiResponse;
using Domain;

namespace Business.Animal.Fetch;

public interface IGetById : ICommand<Guid, ApiResponse<List<MAnimal>>>
{
}