using System.ComponentModel.DataAnnotations;
using TimeToChange.Data;

namespace TimeToChange.Calculation.DTOs;

public record CalculationData
{
    [Required]
    public required int UserId { get; set; }

    [Required]
    public required string CurrencyCode { get; set; }
    
    [Required]
    public required List<Income> Incomes { get; set; }
    
    [Required]
    public required List<Expense> Expenses { get; set; }
    
    [Required]
    public required List<Goal> Goals { get; set; }
}