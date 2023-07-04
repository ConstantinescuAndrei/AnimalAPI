using System.ComponentModel.DataAnnotations;

namespace Data.Register.Entities;

public class EUser
{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    public string Username { get; set; }
    
    [Required]
    public string Password { get; set; }
    
    [Required]
    public string Email { get; set; }
}