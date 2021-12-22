using System;
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
    public class CampaignController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public CampaignController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CampaignModel>> GetCampaign(long id)
        {
            Logger.Trace("CampaignController::GetCampaign");

            var campaign = await _context.Campaign.FindAsync(id);

            if (campaign == null)
            {
                return NotFound();
            }

            return new CampaignModel() { ID = campaign.ID, Name = campaign.Name, PreviewImage = campaign.PreviewImage };
        }

        [HttpPost]
        public async Task<ActionResult<CampaignModel>> PostCampaign(CampaignPayload payload)
        {
            Logger.Trace("CampaignController::PostCampaign");

            try
            {
                Campaign campaign = new()
                {
                    Name = payload.Name,
                    PreviewImage = payload.PreviewImage
                };

                await _context.Campaign.AddAsync(campaign);
                await _context.SaveChangesAsync();

                return Ok(new CampaignModel() { ID = campaign.ID, Name = campaign.Name, PreviewImage = campaign.PreviewImage });
            }
            catch (Exception exception)
            {
                Logger.Exception(exception);
                return Problem(exception.Message);
            }
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchCampaign(long id, CampaignPayload payload)
        {
            Logger.Trace("CampaignController::PatchCampaign");

            try
            {
                var campaign = await _context.Campaign.FindAsync(id);

                if (campaign == null)
                {
                    return NotFound();
                }

                Campaign payloadCampaignInformation = new() { Name = payload.Name, PreviewImage = payload.PreviewImage };

                JsonPatchDocument<Campaign> patch = JsonPatch.From(payloadCampaignInformation, new List<string> { "id" });

                patch.ApplyTo(campaign, ModelState);

                await _context.SaveChangesAsync();

                return Ok(new CampaignModel() { ID = campaign.ID, Name = campaign.Name, PreviewImage = campaign.PreviewImage });
            }
            catch (Exception exception)
            {
                Logger.Exception(exception);
                return Problem(exception.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<uint>> DeleteCampaign(long id)
        {
            Logger.Trace("CampaignController::Campaign");

            var campaign = await _context.Campaign.FindAsync(id);

            if (campaign == null)
            {
                return 0;
            }

            _context.Campaign.Remove(campaign);
            await _context.SaveChangesAsync();

            return 1;
        }
    }
}