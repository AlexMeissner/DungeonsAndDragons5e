using Microsoft.AspNetCore.Mvc;
using System;
using RestAPI.Utility;
using RestAPI.Payload;
using RestAPI.DatabaseSchema;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateUserController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public CreateUserController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult PostCreateUser(CreateUserPayload payload)
        {            
            Logger.Trace("CreateUserController::PostCreateUser");

            try
            {
                User user = new()
                {
                    Name = payload.Name,
                    Password = payload.Passsword
                };
                
                _context.User.Add(user);
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception exception)
            {
                Logger.Exception(exception);
                return Problem();
            }            
        }
    }
}