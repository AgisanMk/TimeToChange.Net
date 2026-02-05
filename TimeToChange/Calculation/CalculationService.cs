using Microsoft.AspNetCore.Http.HttpResults;
using TimeToChange.Calculation.DTOs;
using TimeToChange.Calculation.Interfaces;
using TimeToChange.Data;
using TimeToChange.Temp;

namespace TimeToChange.Calculation;

public class CalculationService(
    IExpensesService expensesService,
    IFinancialLevelService financialLevelService,
    IGoalsService goalsService,
    IIncomesService incomesService) : ICalculationService
{
    public CalculationResult Calculate(CalculationData data)
    {
        var user = TempDataBase.Users.FirstOrDefault(x => x.Id == data.UserId);
        if (user == null) { throw new Exception($"User '{data.UserId}' not found."); }
        
        var currency = TempDataBase.Currencies.FirstOrDefault(x => x.Code == data.CurrencyCode);
        if (currency == null) { throw new Exception($"Currency '{data.CurrencyCode}' not found."); }

        var incomes = incomesService.CalculateIncomes(data.Incomes);
        var expenses = expensesService.CalculateExpenses(data.Expenses);
        var goals = goalsService.CalculateGoals(data.Goals);
        var financialLevel = financialLevelService.CalculationFinancialLevel(incomes, expenses, goals);
        
        return new CalculationResult
        {
            Id = 0,
            User = user,
            Incomes = incomes,
            Expenses = expenses,
            Goals = goals,
            FinancialLevel = financialLevel
        };
    }
}