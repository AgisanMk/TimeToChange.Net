using System.ComponentModel.DataAnnotations;

namespace TimeToChange.Data;

public record User
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public required string Name { get; set; }
  
    [Required]
    public required Country Country { get; set; }
}