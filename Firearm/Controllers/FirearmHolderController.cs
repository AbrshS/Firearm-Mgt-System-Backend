using Firearm.Controllers.Models;
using Firearm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Firearm.Controllers.Civillian_Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class FirearmHolderController : Controller
    {
        private readonly FirearmDbContext firearmDbContext;

        public FirearmHolderController(FirearmDbContext context)
        {
            firearmDbContext = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostFirearmHolder([FromBody] FirearmHolders firearmHolder)
        {
            try
            {
                // Add the new firearm holder to the database
                firearmDbContext.firearmHolders.Add(firearmHolder);
                await firearmDbContext.SaveChangesAsync();

                return CreatedAtAction(nameof(PostFirearmHolder), firearmHolder);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while adding the firearm holder: " + ex.Message);
            }
        }

        [HttpGet("firearm-type-counts")]
        public async Task<IActionResult> GetFirearmTypeCounts()
        {
            try
            {
                var firearmHolderCounts = await firearmDbContext.firearmHolders
                    .GroupBy(f => f.holder)
                    .Select(g => new { holder = g.Key, Count = g.Count() })
                    .ToListAsync();

                return Ok(firearmHolderCounts);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while fetching firearm type counts: " + ex.Message);
            }
        }
    }
}
