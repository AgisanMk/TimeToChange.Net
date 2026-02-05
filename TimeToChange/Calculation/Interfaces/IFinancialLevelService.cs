using TimeToChange.Calculation.DTOs;

namespace TimeToChange.Calculation.Interfaces;

public interface IFinancialLevelService
{
    FinancialLevel CalculationFinancialLevel(Incomes incomes, Expenses expenses, Goals goals);
}