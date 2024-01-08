using Microsoft.AspNetCore.Mvc;

namespace Say_Hello.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetingController : ControllerBase
{
    [HttpGet]
    [Route("GetInput/{userName}")]
    public string GetHello(string userName) {
        return "Hello, " + userName + ".";
    }
}