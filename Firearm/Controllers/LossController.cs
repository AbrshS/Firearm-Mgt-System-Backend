using Firearm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LossController : Controller
    {
        private readonly FirearmDbContext firearmDbContext;

        public LossController(FirearmDbContext firearmDbContext)
        {
            this.firearmDbContext = firearmDbContext;
        }


        // Get all Lost Firearms
        [HttpGet]
        public async Task<IActionResult> GetAllLosses()
        {
            var Losses = await firearmDbContext.Losses.ToListAsync();
            return Ok(Losses);
        }


        // Get single firearm using the id 

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLosses([FromRoute] int id)
        {
            var Loss = await firearmDbContext.Losses.FirstOrDefaultAsync(f => f.Id == id);
            if (Loss == null)
            {
                return NotFound("Loss firearm not Found");
            }
            return Ok(Loss);
        }


        // Add a lost firearm with a new integer id 
        // Add a lost firearm with a new integer id 
        [HttpPost]
        public async Task<IActionResult> AddLoss([FromBody] Firearm.Controllers.Models.Loss loss)
        {
            try
            {
                loss.DateLost = DateTime.UtcNow; // Set the DateLost property to the current date/time
                await firearmDbContext.Losses.AddAsync(loss);
                await firearmDbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(AddLoss), new { id = loss.Id }, loss);
            }
            catch (Exception ex)
            {
                // Handle the exception and return an error response
                return StatusCode(500, "An error occurred while adding the lost firearm: " + ex.Message);
            }
        }


        // Update a loss firearm using the new id
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLoss([FromRoute] int id, [FromBody] Firearm.Controllers.Models.Loss loss)
        {
            var existingLoss = await firearmDbContext.Losses.FirstOrDefaultAsync(f => f.Id == id);
            if (existingLoss != null)
            {
                // Update the properties of the existing firearm


                // Update other propertes here

                await firearmDbContext.SaveChangesAsync();
                return Ok(existingLoss);
            }
            return NotFound("Officer Not Found");
        }

        // Delete an lossfirearm by ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoss([FromRoute] int id)
        {
            var lossToDelete = await firearmDbContext.Losses.FirstOrDefaultAsync(f => f.Id == id);
            if (lossToDelete != null)
            {
                try
                {
                    firearmDbContext.Losses.Remove(lossToDelete);
                    await firearmDbContext.SaveChangesAsync();
                    return Ok("loss firearm deleted successfully");
                }
                catch (Exception ex)
                {
                    // Handle the exception and return an error response
                    return StatusCode(500, "An error occurred while deleting the lost firearm: " + ex.Message);
                }
            }
            return NotFound("lost firearm Not Found");
        }

        [HttpGet("total-loss")]
        public async Task<IActionResult> GetTotalFirearms()
        {
            var totalLosses = await firearmDbContext.Losses.CountAsync();
            return Ok(totalLosses);
        }

        [HttpGet("count-losses/day")]
        public async Task<IActionResult> CountLossesByDay()
        {
            try
            {
                var startDate = DateTime.Today; // Start of the current day
                var endDate = startDate.AddDays(1); // End of the current day
                var lossesCount = await firearmDbContext.Losses
                    .Where(l => l.DateLost >= startDate && l.DateLost < endDate)
                    .CountAsync();

                return Ok(lossesCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while counting losses for the day: " + ex.Message);
            }
        }

        [HttpGet("count-losses/week")]
        public async Task<IActionResult> CountLossesByWeek()
        {
            try
            {
                var startDate = DateTime.Today.AddDays(-7); // Start of the week (7 days ago)
                var endDate = DateTime.Today.AddDays(1); // End of the current day
                var lossesCount = await firearmDbContext.Losses
                    .Where(l => l.DateLost >= startDate && l.DateLost < endDate)
                    .CountAsync();

                return Ok(lossesCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while counting losses for the week: " + ex.Message);
            }
        }

        [HttpGet("count-losses/month")]
        public async Task<IActionResult> CountLossesByMonth()
        {
            try
            {
                var startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); // Start of the current month
                var endDate = startDate.AddMonths(1); // Start of the next month
                var lossesCount = await firearmDbContext.Losses
                    .Where(l => l.DateLost >= startDate && l.DateLost < endDate)
                    .CountAsync();

                return Ok(lossesCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while counting losses for the month: " + ex.Message);
            }
        }

        [HttpGet("count-losses/year")]
        public async Task<IActionResult> CountLossesByYear()
        {
            try
            {
                var startDate = new DateTime(DateTime.Today.Year, 1, 1); // Start of the current year
                var endDate = startDate.AddYears(1); // Start of the next year
                var lossesCount = await firearmDbContext.Losses
                    .Where(l => l.DateLost >= startDate && l.DateLost < endDate)
                    .CountAsync();

                return Ok(lossesCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while counting losses for the year: " + ex.Message);
            }
        }

    }
}