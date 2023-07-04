using Data.Animal.Entities;
using Domain;

namespace Data.Animal;

public static class AnimalFactory
{
   public static MAnimal MakeModel(EAnimal animal) => new()
   {
      Id = animal.Id,
      Race = animal.Race,
      Color = animal.Color,
      ImageUrl = animal.ImageUrl,
      UserId = animal.UserId,
   };

   public static EAnimal MakeEntity(MAnimal animal) => new()
   {
      Id = Guid.NewGuid(),
      Race = animal.Race,
      Color = animal.Color,
      ImageUrl = animal.ImageUrl,
      UserId = animal.UserId
   };
}