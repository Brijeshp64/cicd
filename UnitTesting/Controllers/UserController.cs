using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitTesting.Models;

namespace UnitTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = new List<User>
            {
                new User { Id = 1, Name = "Alice", Email = "alice@example.com" },
                new User { Id = 2, Name = "Bob", Email = "bob@example.com" },
                new User { Id = 3, Name = "Charlie", Email = "charlie@example.com" }
            };

            return Ok(users);
        }
    }
}
