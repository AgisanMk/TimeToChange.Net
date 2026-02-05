using System.ComponentModel.DataAnnotations;

namespace TimeToChange.Data;

public record Country
{
    [Required]
    public required string Code { get; set; }
    
    [Required]
    public required string Name { get; set; }
    
    [Required]
    public required Currency Currency { get; set; }
}