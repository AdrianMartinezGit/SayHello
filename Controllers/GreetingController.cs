using Microsoft.AspNetCore.Mvc;

namespace Say_Hello.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetingController : ControllerBase
{
    [HttpGet]
    [Route("GetName/{userName}")]
    public string GetName(string userName) {
        return "Hello, " + userName + ".";
    }
}