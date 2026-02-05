using TimeToChange.Calculation.DTOs;
using TimeToChange.Data;

namespace TimeToChange.Calculation.Interfaces;

public interface IGoalsService
{
    Goals CalculateGoals(List<Goal> goals);
}