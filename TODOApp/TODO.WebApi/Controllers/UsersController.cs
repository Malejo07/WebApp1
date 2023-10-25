using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TODO.WebApi.Controllers
{
    [Route("api/[controller]")]//Atributo
    [ApiController]
    public class UsersController : ControllerBase
    {
       //Constructor
        public UsersController()
        {

        }

        [HttpGet]
        public async Task <IActionResult> GetHelloWordl()
        {
            return Ok("Hello World, siiiiiiiii");
        }

    }
}
