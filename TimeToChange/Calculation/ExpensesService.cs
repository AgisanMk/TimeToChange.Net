using TimeToChange.Calculation.DTOs;
using TimeToChange.Calculation.Interfaces;
using TimeToChange.Data;

namespace TimeToChange.Calculation;

public class ExpensesService : IExpensesService
{
    public Expenses CalculateExpenses(List<Expense> expenses)
    {
        return new Expenses
        {
            List = expenses,
            TotalFixed = CalculateFixedExpenses(expenses),
            TotalVariable = CalculateVariableExpenses(expenses),
            TotalOccasional = CalculateOccasionalExpenses(expenses),
            Total = CalculateTotal(expenses)
        }; 
    }

    private static decimal CalculateFixedExpenses(List<Expense> expenses)
    {
        return expenses
            .Where(e => e.Category == "fixed")
            .Sum(e => e.Amount); 
    }
    
    private static decimal CalculateVariableExpenses(List<Expense> expenses)
    {
        return expenses
            .Where(e => e.Category == "variable")
            .Sum(e => e.Amount); 
    }
    
    private static decimal CalculateOccasionalExpenses(List<Expense> expenses)
    {
        return expenses
            .Where(e => e.Category == "occasional")
            .Sum(e => e.Amount); 
    }
    
    private static decimal CalculateTotal(List<Expense> expenses)
    {
        return expenses.Sum(e => e.Amount); 
    }
}