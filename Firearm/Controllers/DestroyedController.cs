using Firearm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DestroyedController : Controller
    {
        private readonly FirearmDbContext firearmDbContext;

        public DestroyedController(FirearmDbContext firearmDbContext)
        {
            this.firearmDbContext = firearmDbContext;
        }


        // Get all Lost Firearms
        [HttpGet]
        public async Task<IActionResult> GetAllDestroyed()
        {
            var Destroyeds = await firearmDbContext.Destroyeds.ToListAsync();
            return Ok(Destroyeds);
        }


        // Get single firearm using the id 

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllDestroyed([FromRoute] int id)
        {
            var Destroyeds = await firearmDbContext.Destroyeds.FirstOrDefaultAsync(f => f.Id == id);
            if (Destroyeds == null)
            {
                return NotFound("Destroyed firearm not Found");
            }
            return Ok(Destroyeds);
        }


        // Add a lost firearm with a new integer id 
        [HttpPost]
        public async Task<IActionResult> AddDestroyed([FromBody] Firearm.Controllers.Models.Destroyed destroyed)
        {
            try
            {
                destroyed.DateDestroyed = DateTime.UtcNow; // Set the DateLost property to the current date/time
                await firearmDbContext.Destroyeds.AddAsync(destroyed);
                await firearmDbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(AddDestroyed), new { id = destroyed.Id }, destroyed);
            }
            catch (Exception ex)
            {
                // Handle the exception and return an error response
                return StatusCode(500, "An error occurred while adding the lost firearm: " + ex.Message);
            }

        }

        // Update a loss firearm using the new id
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDestroyed([FromRoute] int id, [FromBody] Firearm.Controllers.Models.Destroyed loss)
        {
            var existingDestroyed = await firearmDbContext.Firearms.FirstOrDefaultAsync(f => f.Id == id);
            if (existingDestroyed != null)
            {
                // Update the properties of the existing firearm


                // Update other propertes here

                await firearmDbContext.SaveChangesAsync();
                return Ok(existingDestroyed);
            }
            return NotFound("Destroyed Not Found");
        }


        // Delete an lossfirearm by ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestroyed([FromRoute] int id)
        {
            var DestroyedToDelete = await firearmDbContext.Destroyeds.FirstOrDefaultAsync(f => f.Id == id);
            if (DestroyedToDelete != null)
            {
                try
                {
                    firearmDbContext.Destroyeds.Remove(DestroyedToDelete);
                    await firearmDbContext.SaveChangesAsync();
                    return Ok("Destroyed firearm deleted successfully");
                }

                catch (Exception ex)
                {
                    // Handle the exception and return an error response
                    return StatusCode(500, "An error occurred while deleting the lost firearm: " + ex.Message);
                }
            }
            return NotFound("lost firearm Not Found");
        }

        [HttpGet("total-destroyed")]
        public async Task<IActionResult> GetTotalDestroyedFirearms()
        {
            var totaldestroyed = await firearmDbContext.Destroyeds.CountAsync();
            return Ok(totaldestroyed);
        }


        [HttpGet("count-destroyed/day")]
        public async Task<IActionResult> CountDestroyedByDay()
        {
            try
            {
                var startDate = DateTime.Today; // Start of the current day
                var endDate = startDate.AddDays(1); // End of the current day
                var destroyedCount = await firearmDbContext.Destroyeds
                    .Where(d => d.DateDestroyed >= startDate && d.DateDestroyed < endDate)
                    .CountAsync();

                return Ok(destroyedCount);
            } 

            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while counting destroyed items for the day: " + ex.Message);
            }
        }


        [HttpGet("count-destroyed/week")]
        public async Task<IActionResult> CountDestroyedByWeek()
        {
            try
            {
                var startDate = DateTime.Today.AddDays(-7); // Start of the week (7 days ago)
                var endDate = DateTime.Today.AddDays(1); // End of the current day
                var DestroyedCount = await firearmDbContext.Destroyeds
                    .Where(l => l.DateDestroyed >= startDate && l.DateDestroyed < endDate)
                    .CountAsync();

                return Ok(DestroyedCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while counting losses for the week: " + ex.Message);
            }
        }

        [HttpGet("count-destroyed/month")]
        public async Task<IActionResult> CountDestroyedLossesByMonth()
        {
            try
            {
                var startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); // Start of the current month
                var endDate = startDate.AddMonths(1); // Start of the next month
                var DestroyedCount = await firearmDbContext.Destroyeds
                    .Where(l => l.DateDestroyed >= startDate && l.DateDestroyed < endDate)
                    .CountAsync();

                return Ok(DestroyedCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while counting losses for the month: " + ex.Message);
            }
        }

        [HttpGet("count-destroyed/year")]
        public async Task<IActionResult> CountDestroyedLossesByYear()
        {
            try
            {
                var startDate = new DateTime(DateTime.Today.Year, 1, 1); // Start of the current year
                var endDate = startDate.AddYears(1); // Start of the next year
                var DestroyedCount = await firearmDbContext.Destroyeds
                    .Where(l => l.DateDestroyed >= startDate && l.DateDestroyed < endDate)
                    .CountAsync();

                return Ok(DestroyedCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while counting losses for the year: " + ex.Message);
            }
        }

    }
}
