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
        public async Task<ActionResult<User>> PostProduct(User product)
        {
            _configuration.Users.Add(product);
            await _configuration.SaveChangesAsync();

            return CreatedAtAction(nameof(PostProduct), new { id = product.Id }, product);
        }




        //[HttpPost]
        //public IActionResult InsertUser(User user)
        //{
        //    string query = @"INSERT INTO users (Name, Email) VALUES (@Name, @Email)";
        //    string sqlDataSource = _configuration.GetConnectionString("dbconn");

        //    using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
        //    {
        //        myCon.Open();
        //        using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
        //        {
        //            myCommand.Parameters.AddWithValue("@Name", user.Name);
        //            myCommand.Parameters.AddWithValue("@Email", user.Email);

        //            myCommand.ExecuteNonQuery();
        //            myCon.Close();
        //        }
        //    }

        //    return Ok(new { message = "User inserted successfully!" });
        //}

    }
}
