using System.ComponentModel.DataAnnotations;

namespace Data.Animal.Entities;

public class EAnimal
{
   [Required]
   public Guid Id { get; set; }
   
   [Required]
   public string Race { get; set; }
   
   [Required]
   public string Color { get; set; }
   
   [Required]
   public string ImageUrl { get; set; }
   
   [Required]
   public Guid UserId { get; set; }
}