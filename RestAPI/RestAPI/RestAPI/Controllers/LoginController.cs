using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI.Models;
using RestAPI.Payload;
using RestAPI.Utility;
using RestAPI.DatabaseSchema;

namespace RestAPI.Controllers
{
    [Route("api/User/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public LoginController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<UserModel>> PostLogin(LoginPayload payload)
        {
            Logger.Trace("LoginController::PostLogin");

            try
            {
                var user = await _context.User.FirstOrDefaultAsync(x => x.Name == payload.Name && x.Password == payload.Passsword);

                if (user == default(User))
                {
                    return Unauthorized(new { code = "INVALID_LOGIN", message = "No user exists with the given name and password." });
                }

                return new UserModel() { ID = user.ID, Name = user.Name };
            }
            catch (Exception exception)
            {
                Logger.Exception(exception);
                return Problem(exception.Message);
            }
        }
    }
}