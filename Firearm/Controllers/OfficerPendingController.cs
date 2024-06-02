using Firearm.Controllers.Models;
using Firearm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfficerPendingController : Controller
    {
        private readonly FirearmDbContext _firearmDbContext;
        private readonly ILogger<OfficerPendingController> _logger;

        public OfficerPendingController(FirearmDbContext firearmDbContext, ILogger<OfficerPendingController> logger)
        {
            _firearmDbContext = firearmDbContext;
            _logger = logger;
        }

        // Get all Officers
        [HttpGet]
        public async Task<IActionResult> GetAllOfficerPending()
        {
            _logger.LogInformation("Getting all officer pending records");
            var officerPending = await _firearmDbContext.officerPendings.ToListAsync();
            return Ok(officerPending);
        }

        // Get single OfficerPending by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOfficerPending([FromRoute] int id)
        {
            _logger.LogInformation("Getting officer pending record with ID {Id}", id);
            var officerPending = await _firearmDbContext.officerPendings.FirstOrDefaultAsync(f => f.Id == id);
            if (officerPending == null)
            {
                _logger.LogWarning("Officer pending record with ID {Id} not found", id);
                return NotFound("OfficerPending not found");
            }
            return Ok(officerPending);
        }

        // Add a new OfficerPending
        [HttpPost]
        public async Task<IActionResult> AddOfficerPending([FromBody] OfficerPending officerPending)
        {
            _logger.LogInformation("Adding a new officer pending record");
            try
            {
                await _firearmDbContext.officerPendings.AddAsync(officerPending);
                await _firearmDbContext.SaveChangesAsync();
                _logger.LogInformation("Officer pending record added successfully with ID {Id}", officerPending.Id);
                return CreatedAtAction(nameof(GetOfficerPending), new { id = officerPending.Id }, officerPending);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding officer pending record");
                return StatusCode(500, "An error occurred while adding the officer pending record: " + ex.Message);
            }
        }

        // Update an existing OfficerPending by ID
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOfficerPending([FromRoute] int id, [FromBody] OfficerPending officerPending)
        {
            _logger.LogInformation("Updating officer pending record with ID {Id}", id);
            var existingOfficerPending = await _firearmDbContext.officerPendings.FirstOrDefaultAsync(f => f.Id == id);
            if (existingOfficerPending != null)
            {
                // Update properties of the existing officer pending record
                existingOfficerPending.FullName = officerPending.FullName;
                existingOfficerPending.FpId = officerPending.FpId;
                existingOfficerPending.Title = officerPending.Title;
                existingOfficerPending.Position = officerPending.Position;
                existingOfficerPending.Email = officerPending.Email;
                existingOfficerPending.PhoneNumber = officerPending.PhoneNumber;
                existingOfficerPending.Description = officerPending.Description;

                // Firearm Detail
                existingOfficerPending.ManufacturerSerial = officerPending.ManufacturerSerial;
                existingOfficerPending.IsFirearm = officerPending.IsFirearm;
                existingOfficerPending.DateMarked = officerPending.DateMarked;
                existingOfficerPending.MarkedBy = officerPending.MarkedBy;
                existingOfficerPending.FirearmType = officerPending.FirearmType;
                existingOfficerPending.FirearmModel = officerPending.FirearmModel;
                existingOfficerPending.FirearmMechanism = officerPending.FirearmMechanism;
                existingOfficerPending.FirearmCalibre = officerPending.FirearmCalibre;
                existingOfficerPending.MagazineCapacity = officerPending.MagazineCapacity;
                existingOfficerPending.Manufacturer = officerPending.Manufacturer;
                existingOfficerPending.YearManufacture = officerPending.YearManufacture;
                existingOfficerPending.Source = officerPending.Source;
                existingOfficerPending.Store = officerPending.Store;
                existingOfficerPending.Holder = officerPending.Holder;
                existingOfficerPending.AdditionalComment = officerPending.AdditionalComment;

                // The body that registered the weapon
                existingOfficerPending.RegisteredPosition = officerPending.RegisteredPosition;
                existingOfficerPending.RegisteredFullName = officerPending.RegisteredFullName;
                existingOfficerPending.RegisteredTitle = officerPending.RegisteredTitle;
                existingOfficerPending.RegisteredEmail = officerPending.RegisteredEmail;
                existingOfficerPending.RegisteredSignature = officerPending.RegisteredSignature;
                existingOfficerPending.RegisteredDate = officerPending.RegisteredDate;

                // The registered body
                existingOfficerPending.RegisteredBodyFullName = officerPending.RegisteredBodyFullName;
                existingOfficerPending.RegisteredBodyResponsibility = officerPending.RegisteredBodyResponsibility;
                existingOfficerPending.RegisteredBodySignature = officerPending.RegisteredBodySignature;
                existingOfficerPending.RegisteredBodyDate = officerPending.RegisteredBodyDate;

                try
                {
                    await _firearmDbContext.SaveChangesAsync();
                    _logger.LogInformation("Officer pending record with ID {Id} updated successfully", id);
                    return Ok(existingOfficerPending);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error occurred while updating officer pending record with ID {Id}", id);
                    return StatusCode(500, "An error occurred while updating the officer pending record: " + ex.Message);
                }
            }
            _logger.LogWarning("Officer pending record with ID {Id} not found for update", id);
            return NotFound("OfficerPending not found");
        }


        // Delete an OfficerPending by ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOfficerPending([FromRoute] int id)
        {
            _logger.LogInformation("Deleting officer pending record with ID {Id}", id);
            var officerPendingToDelete = await _firearmDbContext.officerPendings.FirstOrDefaultAsync(f => f.Id == id);
            if (officerPendingToDelete != null)
            {
                try
                {
                    _firearmDbContext.officerPendings.Remove(officerPendingToDelete);
                    await _firearmDbContext.SaveChangesAsync();
                    _logger.LogInformation("Officer pending record with ID {Id} deleted successfully", id);
                    return Ok("OfficerPending deleted successfully");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error occurred while deleting officer pending record with ID {Id}", id);
                    return StatusCode(500, "An error occurred while deleting the officer pending record: " + ex.Message);
                }
            }
            _logger.LogWarning("Officer pending record with ID {Id} not found for deletion", id);
            return NotFound("OfficerPending not found");
        }
    }
}
