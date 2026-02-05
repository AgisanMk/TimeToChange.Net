using TimeToChange.Calculation.DTOs;
using TimeToChange.Calculation.Interfaces;

namespace TimeToChange.Calculation;

public class FinancialLevelService : IFinancialLevelService
{
    public FinancialLevel CalculationFinancialLevel(Incomes incomes, Expenses expenses, Goals goals)
    {
        var costs = expenses.Total + goals.TotalMonthly;
        
        if (costs == 0) return FinancialLevels.Excellent(incomes.Total);
        
        var ratio = incomes.Total / costs * 100;
        var missingAmount = costs - incomes.Total;
        var surplusAmount = incomes.Total - costs;

        
        return ratio switch
        {
            < 100 => FinancialLevels.TooLow(missingAmount),
            < 120 => FinancialLevels.Optimal(surplusAmount),
            _ => FinancialLevels.Excellent(surplusAmount),
        };
    }
    
}