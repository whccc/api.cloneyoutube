using api.cloneyoutube.Model;
using Microsoft.AspNetCore.Mvc;
namespace api.cloneyoutube.Controllers;
[ApiController]
[Route("/auth")]

public class AuthController : ControllerBase
{

    private readonly DBContextApp dbContext;
    public AuthController(DBContextApp dbContextApp)
    {
        dbContext = dbContextApp;
    }

    [HttpPost]
    [Route("login")]
    public IActionResult login([FromBody] object data)
    {
        Console.WriteLine(data);

        dbContext.Users.ToList();
        Console.WriteLine(dbContext.Users.ToList().ToString());
        return Ok(new
        {

            data = dbContext.Users.ToList()
        });
    }


}