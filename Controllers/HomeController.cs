using Blog.Data;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

[ApiController]
[Route("")]
public class HomeController : ControllerBase
{
    [ApiExplorerSettings(IgnoreApi = true)] // resolvendo o problema -> Failed to load API definition
    [Route("")]
    public IActionResult Index(
        [FromServices] IConfiguration config, 
        [FromServices] BlogDataContext context)
    {
        //Health check
        return Ok();
    }
}