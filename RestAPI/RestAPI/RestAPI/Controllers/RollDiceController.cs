using Microsoft.AspNetCore.Mvc;
using RestAPI.Models;
using RestAPI.Utility;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RollDiceController : ControllerBase
    {
        [HttpGet]
        public ActionResult<RollDice> GetRollDice()
        {
            Logger.Trace();
            return DiceRoller.RollDice(Dice.D10);
        }
    }
}