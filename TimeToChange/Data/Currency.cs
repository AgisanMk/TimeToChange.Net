using System.ComponentModel.DataAnnotations;

namespace TimeToChange.Data;

public record Currency
{
    [Required]
    public required string Code { get; set; }
    
    [Required]
    public required string Symbol { get; set; }
    
    [Required]
    public required string Name { get; set; }
}