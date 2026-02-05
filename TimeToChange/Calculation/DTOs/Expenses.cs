using TimeToChange.Data;

namespace TimeToChange.Calculation.DTOs;

public record Expenses
{
    public required  List<Expense>List { get; set; }
    
    public required decimal TotalFixed{ get; set; }
    
    public required decimal TotalVariable { get; set; }
    
    public required decimal TotalOccasional { get; set; }
    
    public required decimal Total { get; set; }
}