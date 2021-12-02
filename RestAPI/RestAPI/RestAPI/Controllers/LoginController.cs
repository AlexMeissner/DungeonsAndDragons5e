using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using RestAPI.Models;
using RestAPI.Payload;
using RestAPI.Utility;
using RestAPI.DatabaseSchema;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public LoginController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult<Login> PostLogin(LoginPayload payload)
        {
            Logger.Trace("LoginController::PostLogin");

            try
            {
                User user = _context.User.FirstOrDefault(x => x.Name == payload.Name && x.Password == payload.Passsword);

                if (user == default(User))
                {
                    return Unauthorized(new { code = "INVALID_LOGIN", message = "No user exists with the given name and password." });
                }

                //var t = CreatedAtAction("Login", new { id = user.ID, name = user.Name }, payload);
                //
                //return t;

                return Ok();
            }
            catch (Exception exception)
            {
                Logger.Exception(exception);
                return Unauthorized();
            }
        }
    }
}