namespace TimeToChange.Data;

public record Income
{
    public required string Name {get; set;}
    
    public required decimal Amount {get; set;}
    
    public required string Category {get; set;}
}