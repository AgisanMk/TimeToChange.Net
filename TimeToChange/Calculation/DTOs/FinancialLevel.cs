namespace TimeToChange.Calculation.DTOs;

public record FinancialLevel
{
    public required int? Id { get; set; }
    
    public required string? Name { get; set; }
    
    public required string? Text { get; set; }
    
    public required decimal MissingAmount { get; set; }
    
    public required decimal SurplusAmount { get; set; }
}