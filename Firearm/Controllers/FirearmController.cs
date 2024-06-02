using Firearm.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FirearmController : Controller
    {
        private readonly FirearmDbContext firearmDbContext;

        public FirearmController(FirearmDbContext firearmDbContext)
        {
            this.firearmDbContext = firearmDbContext;
        }

        // Get all Firearms
        [HttpGet("firearm")]  
        public async Task<IActionResult> GetAllFirearms()
        {
            var Firearms = await firearmDbContext.Firearms.ToListAsync();
            return Ok(Firearms);
        }

        [HttpGet("firearm-type-counts")]
        public async Task<IActionResult> GetFirearmTypeCounts()
        {
            try
            {
                var firearmTypeCounts = await firearmDbContext.Firearms
                    .GroupBy(f => f.FirearmType)
                    .Select(g => new { FirearmType = g.Key, Count = g.Count() })
                    .ToListAsync();

                return Ok(firearmTypeCounts);
            }
            catch (Exception ex)
            {
                // Handle the exception and return an error response
                return StatusCode(500, "An error occurred while fetching firearm type counts: " + ex.Message);
            }
        }

        [HttpGet("firearm-source-counts")]
        public async Task<IActionResult> GetFirearmSourceCounts()
        {
            try
            {
                var firearmSourceCounts = await firearmDbContext.Firearms
                    .GroupBy(f => f.Source)
                    .Select(g => new { Source = g.Key, Count = g.Count() })
                    .ToListAsync();

                return Ok(firearmSourceCounts);
            }
            catch (Exception ex)
            {
                // Handle the exception and return an error response
                return StatusCode(500, "An error occurred while fetching firearm type counts: " + ex.Message);
            }
        }

        // Get single firearm using the new Guid ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFirearm([FromRoute] int id)
        {
            var firearm = await firearmDbContext.Firearms.FirstOrDefaultAsync(f => f.Id == id);
            if (firearm == null)
            {
                return NotFound("Firearm not Found");
            }
            return Ok(firearm);
        }

        // Add a firearm with a new Guid ID
        [HttpPost]
        public async Task<IActionResult> AddFirearm([FromBody] Firearm.Controllers.Models.Firearm firearm)
        {
            try
            {
                // firearm.Id = Guid.NewGuid(); // Generate a new Guid for the ID, if needed
                firearm.DateAdded = DateTime.UtcNow; // Set the DateAdded property to the current date/time
                await firearmDbContext.Firearms.AddAsync(firearm);
                await firearmDbContext.SaveChangesAsync();

                var response = new
                {
                    Message = "Firearm successfully added.",
                    Firearm = firearm
                };

                return CreatedAtAction(nameof(AddFirearm), new { id = firearm.Id }, response);
            }
            catch (Exception ex)
            {
                // Handle the exception and return an error response
                return StatusCode(500, "An error occurred while adding the firearm: " + ex.Message);
            }
        }


        // Update a firearm using the new Guid ID
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFirearm([FromRoute] int id, [FromBody] Firearm.Controllers.Models.Firearm firearm)
        {
            var existingFirearm = await firearmDbContext.Firearms.FirstOrDefaultAsync(f => f.Id == id);
            if (existingFirearm != null)
            {
                // Update the properties of the existing firearm
                existingFirearm.ManufacturerSerial = firearm.ManufacturerSerial;
                existingFirearm.DateMarked = firearm.DateMarked;
                existingFirearm.MarkedBy = firearm.MarkedBy;
                existingFirearm.FirearmType = firearm.FirearmType;
                existingFirearm.FirearmModel = firearm.FirearmModel;
                existingFirearm.FirearmMechanism = firearm.FirearmMechanism;
                existingFirearm.FirearmCalibre = firearm.FirearmCalibre;
                existingFirearm.MagazineCapacity = firearm.MagazineCapacity;
                existingFirearm.Manufacturer = firearm.Manufacturer;
                existingFirearm.YearManufacture = firearm.YearManufacture;
                existingFirearm.Source = firearm.Source;
                existingFirearm.Store = firearm.Store;
                existingFirearm.AdditionalComment = firearm.AdditionalComment;

                // Update other propertes here

                await firearmDbContext.SaveChangesAsync();
                return Ok(existingFirearm);
            }
            return NotFound("Firearm Not Found");
        }

        // Implement other actions such as Delete, if needed


        [HttpGet("total-firearms")]
        public async Task<IActionResult> GetTotalFirearms()
        {
            var totalFirearms = await firearmDbContext.Firearms.CountAsync();
            return Ok(totalFirearms);
        }

        // Delete a firearm using the new Guid ID

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFirearm([FromRoute] int id)
        {
            var firearmToDelete = await firearmDbContext.Firearms.FirstOrDefaultAsync(f => f.Id == id);

            if (firearmToDelete == null)
            {
                return NotFound("Officer not found");
            }

            try
            {
                firearmDbContext.Firearms.Remove(firearmToDelete);
                await firearmDbContext.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                // Consider returning a more detailed error message for production
                return StatusCode(500, "An error occurred while deleting the officer: " + ex.Message);
            }
        }

        [HttpGet("count-deleted-firearms")]
        public async Task<IActionResult> GetDeletedFirearmsCount()
        {
            try
            {
                var deletedFirearmsCount = await firearmDbContext.Firearms
                    .Where(f => f.IsDeleted)
                    .CountAsync();

                return Ok(deletedFirearmsCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving deleted firearms count: " + ex.Message);
            }
        }

        // Add a new action to count firearms where IsFirearm is true
        [HttpGet("count-true-firearms")]
        public async Task<IActionResult> CountTrueFirearms()
        {
            try
            {
                var count = await firearmDbContext.Firearms.CountAsync(f => f.IsFirearm);
                return Ok(count);
            }
            catch (Exception ex)
            {
                // Handle the exception and return an error response
                return StatusCode(500, "An error occurred while counting true firearms: " + ex.Message);
            }
        }

        [HttpGet("count-daily-returned-firearm")]
        public async Task<IActionResult> GetDailyReturnedFirearms()
        {
            try
            {
                var startDate = DateTime.Today; // Start of the current day
                var endDate = startDate.AddDays(1); // End of the current day
                var firearmsCount = await firearmDbContext.Firearms
                    .Where(f => f.DateAdded >= startDate && f.DateAdded < endDate && f.Status == "returned")
                    .CountAsync();

                return Ok(firearmsCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving daily returned firearms count: " + ex.Message);
            }
        }
        [HttpGet("weekly")]
        public async Task<IActionResult> GetWeeklyReturnedFirearms()
        {
            try
            {
                // Set the start date to 7 days ago and the end date to the start of tomorrow
                var startDate = DateTime.Today.AddDays(-7);
                var endDate = DateTime.Today.AddDays(1);

                // Query to count firearms with a "returned" status added in the last 7 days
                var firearmsCount = await firearmDbContext.Firearms
                    .Where(f => f.DateAdded >= startDate && f.DateAdded < endDate && f.Status == "returned")
                    .CountAsync();

                return Ok(firearmsCount);
            }
            catch (Exception ex)
            {
                // Log the exception (optional if logging is configured)
                // _logger.LogError(ex, "An error occurred while retrieving weekly returned firearms count");

                return StatusCode(500, $"An error occurred while retrieving weekly returned firearms count: {ex.Message}");
            }
        }


        [HttpGet("monthly")]
        public async Task<IActionResult> GetMonthlyReturnedFirearms()
        {
            try
            {
                var startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); // Start of the current month
                var endDate = startDate.AddMonths(1); // Start of the next month
                var firearmsCount = await firearmDbContext.Firearms
                    .Where(f => f.DateAdded >= startDate && f.DateAdded < endDate && f.Status == "returned")
                    .CountAsync();

                return Ok(firearmsCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving monthly returned firearms count: " + ex.Message);
            }
        }

        [HttpGet("yearly")]
        public async Task<IActionResult> GetYearlyReturnedFirearms()
        {
            try
            {
                var startDate = new DateTime(DateTime.Today.Year, 1, 1); // Start of the current year
                var endDate = startDate.AddYears(1); // Start of the next year
                var firearmsCount = await firearmDbContext.Firearms
                    .Where(f => f.DateAdded >= startDate && f.DateAdded < endDate && f.Status == "returned")
                    .CountAsync();

                return Ok(firearmsCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving yearly returned firearms count: " + ex.Message);
            }
        }


        [HttpGet("count-daily-recoverd-firearm")]
        public async Task<IActionResult> GetDailyRecoverFirearms()
        {
            try
            {
                var startDate = DateTime.Today; // Start of the current day
                var endDate = startDate.AddDays(1); // End of the current day
                var firearmsCount = await firearmDbContext.Firearms
                    .Where(f => f.DateAdded >= startDate && f.DateAdded < endDate && f.Status == "recovered")
                    .CountAsync();

                return Ok(firearmsCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving daily returned firearms count: " + ex.Message);
            }
        }

        [HttpGet("count-weekly-recover-firearm")]
        public async Task<IActionResult> GetWeeklyRecoverFirearms()
        {
            try
            {
                var startDate = DateTime.Today.AddDays(-7); // Start of the week (7 days ago)
                var endDate = DateTime.Today.AddDays(1); // End of the current day to include today's records

                var firearmsCount = await firearmDbContext.Firearms
                    .Where(f => f.DateAdded >= startDate && f.DateAdded < endDate && f.Status == "recovered")
                    .CountAsync();

                return Ok(firearmsCount);
            }
            catch (Exception ex)
            {
                // Log the exception (if logging is configured)
                // _logger.LogError(ex, "An error occurred while retrieving weekly recovered firearms count");

                return StatusCode(500, "An error occurred while retrieving weekly recovered firearms count: " + ex.Message);
            }
        }


        [HttpGet("count-monthly-recover-firearm")]
        public async Task<IActionResult> GetMonthlyRecoverFirearms()
        {
            try
            {
                var startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); // Start of the current month
                var endDate = startDate.AddMonths(1); // Start of the next month
                var firearmsCount = await firearmDbContext.Firearms
                    .Where(f => f.DateAdded >= startDate && f.DateAdded < endDate && f.Status == "recovered")
                    .CountAsync();

                return Ok(firearmsCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving monthly returned firearms count: " + ex.Message);
            }
        }

        [HttpGet("count-yearly-recover-firearm")]
        public async Task<IActionResult> GetYearlyRecoverFirearms()
        {
            try
            {
                var startDate = new DateTime(DateTime.Today.Year, 1, 1); // Start of the current year
                var endDate = startDate.AddYears(1); // Start of the next year
                var firearmsCount = await firearmDbContext.Firearms
                    .Where(f => f.DateAdded >= startDate && f.DateAdded < endDate && f.Status == "recovered")
                    .CountAsync();

                return Ok(firearmsCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving yearly returned firearms count: " + ex.Message);
            }
        }
    }
}