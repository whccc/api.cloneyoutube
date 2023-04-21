using api.cloneyoutube.AuthControllerModel;
using api.cloneyoutube.Entity;
using api.cloneyoutube.InterfaceRepository;
using api.cloneyoutube.Model;
using Microsoft.AspNetCore.Mvc;
namespace api.cloneyoutube.Controllers;
[ApiController]
[Route("/auth")]

public class AuthController : ControllerBase
{
    private readonly IAuthService authService;
    public AuthController(IAuthService authService)
    {
        this.authService = authService;
    }

    [HttpPost]
    [Route("login")]
    public IActionResult login([FromBody] LoginDTO dataB)
    {
        UserEntity? data = this.authService.login(dataB.email, dataB.clave);
        return data != null ? Ok(data) : StatusCode(401, "Fail Session");
    }


}