using ApiData.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace ApiData.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [HttpPost]
        public IActionResult InsertUser(User user)
        {
            string query = @"INSERT INTO users (Name, Email) VALUES (@Name, @Email)";
            string sqlDataSource = _configuration.GetConnectionString("dbConn");

            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Name", user.Name);
                    myCommand.Parameters.AddWithValue("@Email", user.Email);

                    myCommand.ExecuteNonQuery();
                    myCon.Close();
                }
            }

            return Ok(new { message = "User inserted successfully!" });
        }
   
    }
}
