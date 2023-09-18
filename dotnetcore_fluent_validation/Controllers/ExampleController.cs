using Microsoft.AspNetCore.Mvc;

#region Author
//JonathanNgo
#endregion

namespace dotnetcore_fluent_validation.Controllers;

[Route("api/[controller]")]
public class ExampleController : Controller
{
    public ExampleController()
    {
        
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Nice!");
    }
}