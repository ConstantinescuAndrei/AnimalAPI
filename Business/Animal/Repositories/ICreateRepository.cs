using Business.ApiResponse;
using Domain;

namespace Business.Animal.Repositories;

public interface ICreateRepository
{
    public ApiResponse<MAnimal> Create(MAnimal animal);
}