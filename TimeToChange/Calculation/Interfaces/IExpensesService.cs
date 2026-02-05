using TimeToChange.Calculation.DTOs;
using TimeToChange.Data;

namespace TimeToChange.Calculation.Interfaces;

public interface IExpensesService
{
    Expenses CalculateExpenses(List<Expense> expenses);
}