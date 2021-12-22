using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Models;
using RestAPI.Utility;
using RestAPI.Payload;
using RestAPI.DatabaseSchema;

namespace RestAPI.Controllers
{
    [Route("api/User/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public RegisterController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostRegister(RegisterPayload payload)
        {
            Logger.Trace();

            try
            {
                User user = new()
                {
                    Name = payload.Name,
                    Password = payload.Passsword
                };

                await _context.User.AddAsync(user);
                await _context.SaveChangesAsync();

                return Ok(new UserModel() { ID = user.ID, Name = user.Name });
            }
            catch (Exception exception)
            {
                Logger.Exception(exception);
                return Problem(exception.Message);
            }
        }
    }
}