namespace TimeToChange.Data;

public record Goal
{
    public required string Name { get; set; }
    
    public required decimal PeriodInYears { get; set; }
    
    public required decimal AmountTarget {get; set;}
}