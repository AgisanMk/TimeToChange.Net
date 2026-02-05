using TimeToChange.Data;

namespace TimeToChange.Calculation.DTOs;

public record Incomes
{ 
    public required List<Income>List { get; set; }
    public required decimal TotalFixed { get; set; }
    public required decimal TotalVariable { get; set; }
    public required decimal TotalPassive { get; set; }
    public required decimal Total { get; set; }
}