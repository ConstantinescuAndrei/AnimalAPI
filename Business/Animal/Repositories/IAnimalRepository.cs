using Business.ApiResponse;
using Domain;

namespace Business.Animal.Repositories;

public interface IAnimalRepository
{
    public ApiResponse<MAnimal> Create(MAnimal animal);

    public ApiResponse<List<MAnimal>> GetAll();

    public ApiResponse<List<MAnimal>> GetById(Guid id);
}