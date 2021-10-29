using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI.Models;
using RestAPI.Context;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private readonly CampaignContext _context;

        public CampaignController(CampaignContext context)
        {
            _context = context;
        }

        // GET: api/Campaign
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Campaign>>> GetCampaignItems()
        {
            return await _context.CampaignItems.ToListAsync();
        }

        // GET: api/Campaign/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Campaign>> GetCampaign(long id)
        {
            var campaign = await _context.CampaignItems.FindAsync(id);

            if (campaign == null)
            {
                return NotFound();
            }

            return campaign;
        }

        // PUT: api/Campaign/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCampaign(long id, Campaign campaign)
        {
            if (id != campaign.ID)
            {
                return BadRequest();
            }

            _context.Entry(campaign).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampaignExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Campaign
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Campaign>> PostCampaign(Campaign campaign)
        {
            _context.CampaignItems.Add(campaign);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCampaign), new { id = campaign.ID }, campaign);
        }

        // DELETE: api/Campaign/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCampaign(long id)
        {
            var campaign = await _context.CampaignItems.FindAsync(id);
            if (campaign == null)
            {
                return NotFound();
            }

            _context.CampaignItems.Remove(campaign);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CampaignExists(long id)
        {
            return _context.CampaignItems.Any(e => e.ID == id);
        }
    }
}
