using TimeToChange.Calculation.DTOs;
using TimeToChange.Data;

namespace TimeToChange.Calculation.Interfaces;

public interface IIncomesService
{
    Incomes CalculateIncomes(List<Income> incomes);
}