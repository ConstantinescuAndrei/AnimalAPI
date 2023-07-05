using System.ComponentModel.DataAnnotations;

namespace Data.Comment.Entities;

public class EComment
{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    public Guid ImageId { get; set; }
    
    [Required]
    public Guid UserId { get; set; }
    
    [Required]
    public string Message { get; set; }
}