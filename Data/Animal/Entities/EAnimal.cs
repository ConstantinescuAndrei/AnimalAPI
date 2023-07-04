using System.ComponentModel.DataAnnotations;

namespace Data.Animal.Entities;

public class EAnimal
{
   [Required]
   public Guid Id { get; set; }
   [Required]
   public string Sound { get; set; }
}