using Microsoft.AspNetCore.Mvc;

namespace MyFristAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(typeof(string), 400)]
        public IActionResult Get(int id)
        {
            var response = new User
            {
                Id = id,
                Age = 7,
                Name = "Momó"
            };
            return Ok(response);

        }
        [HttpPost]
        public IActionResult Post()
        {
            return Ok("momo");
        }
    }
}
