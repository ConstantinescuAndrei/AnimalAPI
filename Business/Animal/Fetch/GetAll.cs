using Business.Animal.Repositories;
using Business.ApiResponse;
using Domain;

namespace Business.Animal.Fetch;

public class GetAll : IGetAll
{
    private readonly IAnimalRepository _animalRepository;

    public GetAll(IAnimalRepository animalRepository) => _animalRepository = animalRepository;

    public ApiResponse<List<MAnimal>> Execute() => _animalRepository.GetAll();
}