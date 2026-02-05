using TimeToChange.Data;

namespace TimeToChange.Calculation.DTOs;

public record Goals
{
    public required List<Goal>List { get; set; }
    public required decimal TotalMonthly { get; set; }
    public required decimal TotalTarget { get; set; }
}