using Microsoft.AspNetCore.Mvc;

namespace MenuService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            return Ok();
        }
    }
}
