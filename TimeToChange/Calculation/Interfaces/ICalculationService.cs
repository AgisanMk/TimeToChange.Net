using TimeToChange.Calculation.DTOs;

namespace TimeToChange.Calculation.Interfaces;

public interface ICalculationService
{
    CalculationResult Calculate(CalculationData data);
}