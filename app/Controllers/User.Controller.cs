
using System.Text.Json;
using System.Text.Json.Serialization;
using api.cloneyoutube.Entity;
using api.cloneyoutube.InterfaceRepository;
using Microsoft.AspNetCore.Mvc;

namespace api.cloneyoutube.Controllers
{
    [ApiController]
    [Route("/user")]

    public class UserController : ControllerBase

    {

        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }


        [HttpGet]
        [Route("get-all-users")]
        public IActionResult getAllUsers()
        {

            var data = this.userService.getAllUsers();

            return Ok(data);
        }

    }
}