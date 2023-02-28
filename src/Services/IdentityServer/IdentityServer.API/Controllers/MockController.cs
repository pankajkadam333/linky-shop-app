using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.API.Controllers;

[ApiController]
[Route("[controller]")]

public class MockController : ControllerBase
{
    [HttpGet(Name = "MockGetAllUsers"), Authorize]
    public IActionResult GetAllUsers()
    {
        return Ok(new { Message = "Hello from IdentityServer.API" });
    }

    [HttpPost(Name = "MockGetAdmin"), Authorize(Roles = "Admin")]
    public IActionResult GetAdmin()
    {
        return Ok(new { Message = "Hello from IdentityServer.API" });
    }

    [HttpPut(Name = "Test"), Authorize(Roles = "User")]
    public IActionResult GetTest()
    {
        return Ok(new { Message = "Hello from IdentityServer.API" });
    }
}
