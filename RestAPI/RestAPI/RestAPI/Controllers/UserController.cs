using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;
using RestAPI.Models;
using RestAPI.Utility;
using RestAPI.Payload;
using RestAPI.DatabaseSchema;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public UserController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserModel>> GetUsers()
        {
            Logger.Trace("UserController::GetUsers");

            List<UserModel> users = new();

            foreach (var user in _context.User)
            {
                users.Add(new UserModel() { ID = user.ID, Name = user.Name });
            }

            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> GetUser(long id)
        {
            Logger.Trace("UserController::GetUser");

            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return new UserModel() { ID = user.ID, Name = user.Name };
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchUser(long id, UserPayload payload)
        {
            Logger.Trace("UserController::PatchUser");

            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            User payloadUserInformation = new() { Name = payload.Name, Password = payload.Passsword };

            JsonPatchDocument<User> patch = JsonPatch.From(payloadUserInformation, new List<string> { "id" });

            patch.ApplyTo(user, ModelState);

            await _context.SaveChangesAsync();

            return Ok(new UserModel() { ID = user.ID, Name = user.Name });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<uint>> DeleteUser(long id)
        {
            Logger.Trace("UserController::DeleteUser");

            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return 0;
            }

            _context.User.Remove(user);
            await _context.SaveChangesAsync();

            return 1;
        }
    }
}