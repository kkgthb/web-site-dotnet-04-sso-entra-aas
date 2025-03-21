using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Handwritten.Controllers;

[Authorize(Roles="Xyzzyers")]
[ApiController]
[Route("api/[controller]")]
public class SayHelloController : ControllerBase {
    // You can get this response by visiting "/api/sayhello" (any capitalization of "sayhello" is fine)
    [HttpGet(Name = "GetSayHello")]
    public String Get() {
        return "Hello World";
    }
}