using Microsoft.AspNetCore.Mvc;
using TimeToChange.Calculation.DTOs;
using TimeToChange.Calculation.Interfaces;

namespace TimeToChange.Controllers;

[ApiController]
[Route("calculation")]
public class CalculationController(ICalculationService calculationService) : ControllerBase
{
    [HttpPost]
    public IActionResult Calculate([FromBody] CalculationData data)
    {
        try
        {
            var result = calculationService.Calculate(data);
            return Ok(result);
        }
        catch ( Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }
    }
}