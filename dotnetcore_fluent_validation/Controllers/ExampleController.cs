using dotnetcore_fluent_validation.Models;
using dotnetcore_fluent_validation.ValidationExtensions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

#region Author
//JonathanNgo
#endregion

namespace dotnetcore_fluent_validation.Controllers;

[Route("api/[controller]")]
public class ExampleController : Controller
{
    private readonly IValidator<Product> _validator;
    public ExampleController(IValidator<Product> validator)
    {
        _validator = validator;
    }

    [HttpPost]
    public IActionResult Post([FromBody] Product product)
    {
        return Ok(_validator.Validate(product));
    }
}