using Business.ApiResponse;
using Domain;

namespace Business.Animal.Create;

public interface ICreate : ICommand<MAnimal, ApiResponse<MAnimal>>
{
}