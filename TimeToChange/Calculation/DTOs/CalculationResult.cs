using TimeToChange.Data;

namespace TimeToChange.Calculation.DTOs;

public record CalculationResult
{
    public required int Id { get; set; }
    
    public required User User { get; set; }
    
    public required Incomes Incomes { get; set; }
    
    public required Expenses Expenses { get; set; }
    
    public required Goals Goals { get; set; }
    
    public required FinancialLevel FinancialLevel { get; set; }
}