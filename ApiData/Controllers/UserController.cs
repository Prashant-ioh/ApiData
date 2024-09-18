using ApiData.Data;
using ApiData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace ApiData.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly AppDbContext _configuration;

        public UserController(AppDbContext context)
        {
            _configuration = context;
        }


        [HttpPost]
        public async Task<ActionResult<User>> PostProduct(User user)
        {
            _configuration.Users.Add(user);
            await _configuration.SaveChangesAsync();

            return CreatedAtAction(nameof(PostProduct), new { id = user.Id }, user);
        }
    }
}
