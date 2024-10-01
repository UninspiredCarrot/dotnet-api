using Microsoft.AspNetCore.Mvc;

namespace breakfast.Controllers;

public class ErrorsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}