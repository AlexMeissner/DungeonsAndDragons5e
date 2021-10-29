using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using RestAPI.Context;
using RestAPI.Models;
using RestAPI.Payload;
using RestAPI.DatabaseSchema;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginContext _context;

        public LoginController(LoginContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult<Login> PostLogin(LoginPayload login)
        {
            try
            {
                var user = _context.UserItems.FirstOrDefault(x => x.Name == login.Name);

                if (user == default(User))
                {
                    return Unauthorized(new { code = "INVALID_LOGIN", message = "No user exists with the given name and password." });
                }

                return CreatedAtAction("Login", new { id = user.ID, name = user.Name }, login);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                return Unauthorized();
            }
        }
    }
}