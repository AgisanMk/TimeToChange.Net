using TimeToChange.Calculation.DTOs;
using TimeToChange.Calculation.Interfaces;
using TimeToChange.Data;

namespace TimeToChange.Calculation;

public class IncomesService : IIncomesService
{
    public Incomes CalculateIncomes(List<Income> incomes)
    {
        return new Incomes
        {
            List = incomes,
            TotalFixed = CalculateFixedIncome(incomes),
            TotalVariable = CalculateVariableIncome(incomes),
            TotalPassive = CalculatePassiveIncome(incomes),
            Total = CalculateTotal(incomes),
        };
    }
    
    private static decimal CalculateFixedIncome(List<Income> incomes)
    { 
        return incomes 
            .Where(i =>i.Category == "fixed")
            .Sum(i => i.Amount); 
    }
    
    private static decimal CalculateVariableIncome(List<Income> incomes)
    {
        return incomes
            .Where(i => i.Category == "variable")
            .Sum(i => i.Amount); 
    }
    
    private static decimal CalculatePassiveIncome(List<Income> incomes)
    {
        return incomes
            .Where(i => i.Category == "passive")
            .Sum(i => i.Amount); 
    }
    
    private static decimal CalculateTotal(List<Income> incomes)
    {
        return incomes.Sum(i => i.Amount); 
    }
}