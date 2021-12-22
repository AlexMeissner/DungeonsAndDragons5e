using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Models;
using RestAPI.Utility;
using RestAPI.Payload;
using RestAPI.DatabaseSchema;
using RestAPI.QueryParameter;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCampaignMappingController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public UserCampaignMappingController(DatabaseContext context)
        {
            _context = context;
        }

        // TODO: async
        [HttpGet]
        public ActionResult<IEnumerable<UserCampaignMappingModel>> GetUserCampaignMappings([FromQuery] UserCampaignMappingQueryParameter queryParameter)
        {
            Logger.Trace("UserCampaignMappingController::GetUserCampaignMappings");

            try
            {
                var query = _context.UserCampaignMapping
                .Where(x => queryParameter.UserID == null || queryParameter.UserID == x.UserID)
                .Where(x => queryParameter.CampaignID == null || queryParameter.CampaignID == x.CampaignID)
                .Where(x => queryParameter.IsGameMaster == null || queryParameter.IsGameMaster == x.IsGameMaster)
                .Select(x => new UserCampaignMappingModel() { ID = x.ID, UserID = x.UserID, CampaignID = x.CampaignID, IsGameMaster = x.IsGameMaster });

                return Ok(query.ToList());
            }
            catch (Exception exception)
            {
                Logger.Exception(exception);
                return Problem(exception.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<UserCampaignMappingModel>> PostUserCampaignMapping(UserCampaignMappingPayload payload)
        {
            Logger.Trace("UserCampaignMappingController::PostUserCampaignMapping");

            try
            {
                // TODO: Review -> Result may not be ready
                var mapping = _context.UserCampaignMapping.AddAsync(new UserCampaignMapping()
                {
                    UserID = payload.UserID,
                    CampaignID = payload.CampaignID,
                    IsGameMaster = payload.IsGameMaster
                });
                await _context.SaveChangesAsync();

                var result = mapping.Result.Entity;

                return Ok(new UserCampaignMappingModel() { ID = result.ID, UserID = result.UserID, CampaignID = result.CampaignID, IsGameMaster = result.IsGameMaster });
            }
            catch (Exception exception)
            {
                Logger.Exception(exception);
                return Problem(exception.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<uint>> DeleteUserCampaignMapping(long id)
        {
            Logger.Trace("UserCampaignMappingController::DeleteUserCampaignMapping");

            var mapping = await _context.UserCampaignMapping.FindAsync(id);

            if (mapping == null)
            {
                return 0;
            }

            _context.UserCampaignMapping.Remove(mapping);
            await _context.SaveChangesAsync();

            return 1;
        }
    }
}