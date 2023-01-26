using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayersController : ControllerBase
{
    private readonly List<int> _ints = new();

    [HttpGet(Name = "GetWeatherForecast")]
    public List<int> Get()
    {
        return _ints;
    }

    [HttpPost(Name = "SetWeatherForecast")]
    public bool Post(int i)
    {
        _ints.Add(i);

        return true;
    }
}