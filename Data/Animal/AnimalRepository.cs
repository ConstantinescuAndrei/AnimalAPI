using Business.Animal.Repositories;
using Business.ApiResponse;
using Domain;

namespace Data.Animal;

public class AnimalRepository : IAnimalRepository
{
    private readonly Context _context;

    public AnimalRepository(Context context) => _context = context;

    public ApiResponse<MAnimal> Create(MAnimal animal)
    {
        var entity = AnimalFactory.MakeEntity(animal);
        
        _context.Animals.Add(AnimalFactory.MakeEntity(animal));
        _context.SaveChanges();

        return ApiResponseFactory<MAnimal>.MakeSuccessResponse(AnimalFactory.MakeModel(entity));
    }

    public ApiResponse<List<MAnimal>> GetAll()
    {
        var result = _context.Animals
            .ToList()
            .Select(AnimalFactory.MakeModel)
            .ToList();

        return ApiResponseFactory<List<MAnimal>>.MakeSuccessResponse(result);
    }

    public ApiResponse<List<MAnimal>> GetById(Guid id)
    {
        var result = _context.Animals
            .Where(a => a.UserId == id)
            .ToList()
            .Select(AnimalFactory.MakeModel)
            .ToList();

        return ApiResponseFactory<List<MAnimal>>.MakeSuccessResponse(result);
    }
}