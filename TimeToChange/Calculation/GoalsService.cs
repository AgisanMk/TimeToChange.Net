using TimeToChange.Calculation.DTOs;
using TimeToChange.Calculation.Interfaces;
using TimeToChange.Data;

namespace TimeToChange.Calculation;

public class GoalsService : IGoalsService
{
    public Goals CalculateGoals(List<Goal> goals)
    {
        return new Goals
        {
            List = goals,
            TotalMonthly = CalculateMonthlyTotal(goals),
            TotalTarget = CalculateTotal(goals)
        };
    }
    
    private static decimal CalculateMonthlyTotal(List<Goal> goals)
    {
        return goals.Sum(g => g.AmountTarget / (g.PeriodInYears * 12)); 
    }
    
    private static decimal CalculateTotal(List<Goal> goals)
    {
        return goals.Sum(g => g.AmountTarget); 
    }
}