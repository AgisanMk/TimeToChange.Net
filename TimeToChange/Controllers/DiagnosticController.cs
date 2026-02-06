using Microsoft.AspNetCore.Mvc;
using TimeToChange.Calculation.DTOs;
using TimeToChange.Calculation.Interfaces;

namespace TimeToChange.Controllers;

[ApiController]
[Route("diagnostic")]
public class DiagnosticController(ICalculationService calculationService) : ControllerBase
{
    [HttpGet]
    public IActionResult Test()
    {
        return Ok("Diagnostic OK.");
    }
}