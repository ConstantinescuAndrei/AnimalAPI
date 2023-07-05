using Business.Animal.Repositories;
using Business.ApiResponse;
using Domain;

namespace Business.Animal.Fetch;

public class GetById : IGetById
{
    private readonly IAnimalRepository _animalRepository;

    public GetById(IAnimalRepository animalRepository) => _animalRepository = animalRepository;

    public ApiResponse<List<MAnimal>> Execute(Guid input) => _animalRepository.GetById(input);
}