using Business.Animal.Repositories;
using Business.ApiResponse;
using Domain;

namespace Business.Animal.Create;

public class Create : ICreate
{
    private readonly ICreateRepository _create;

    public Create(ICreateRepository create) => _create = create;

    public ApiResponse<MAnimal> Execute(MAnimal input) => _create.Create(input);
}