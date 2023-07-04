using Business.Animal.Repositories;
using Business.ApiResponse;
using Domain;

namespace Data.Animal;

public class CreateRepository : ICreateRepository
{
    private readonly Context _context;

    public CreateRepository(Context context) => _context = context;

    public ApiResponse<MAnimal> Create(MAnimal animal)
    {
        _context.Animal.Add(AnimalFactory.MakeEntity(animal));
        _context.SaveChanges();

        return ApiResponseFactory<MAnimal>.MakeSuccessResponse(animal);
    }
}