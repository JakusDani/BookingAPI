using Domain.AggregatorContract;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controller;
[Route("[Controller]")]

public class TestController : ControllerBase
{
    private ICityAggregator _cityAggregator;
    public TestController(ICityAggregator cityAggregator)
    {
        _cityAggregator = cityAggregator;
    }
    [HttpGet("AllCities")]
    public async Task<IActionResult> AllCities()
    {
        return Ok(await _cityAggregator.GetAllCities());
    }
    [HttpGet("email")]
    public async Task<IActionResult> Email()
    {
        await _cityAggregator.SendMail();
        return Ok("Email sent.");
    }
}