using Firearm.Data;
using Firearm.Controllers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfficerController : ControllerBase
    {
        private readonly FirearmDbContext _firearmDbContext;
        private readonly ILogger<OfficerController> _logger;

        public OfficerController(FirearmDbContext firearmDbContext, ILogger<OfficerController> logger)
        {
            _firearmDbContext = firearmDbContext;
            _logger = logger;
        }

        // Get all Officers
        [HttpGet]
        public async Task<IActionResult> GetAllOfficer()
        {
            _logger.LogInformation("Getting all officers");
            try
            {
                var officers = await _firearmDbContext.Officers.ToListAsync();
                return Ok(officers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting all officers");
                return StatusCode(500, "Internal server error");
            }
        }

        // Get single officer by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOfficer([FromRoute] int id)
        {
            _logger.LogInformation("Getting officer with ID {Id}", id);
            try
            {
                var officer = await _firearmDbContext.Officers.FirstOrDefaultAsync(o => o.Id == id);
                if (officer == null)
                {
                    _logger.LogWarning("Officer with ID {Id} not found", id);
                    return NotFound("Officer not found");
                }
                return Ok(officer);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting officer with ID {Id}", id);
                return StatusCode(500, "Internal server error");
            }
        }

        // Add a new officer
        [HttpPost]
        public async Task<IActionResult> AddOfficer([FromBody] Officer officer)
        {
            _logger.LogInformation("Adding a new officer");
            try
            {
                await _firearmDbContext.Officers.AddAsync(officer);
                await _firearmDbContext.SaveChangesAsync();
                _logger.LogInformation("Officer added successfully with ID {Id}", officer.Id);
                return CreatedAtAction(nameof(GetOfficer), new { id = officer.Id }, officer);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding officer");
                return StatusCode(500, "Internal server error");
            }
        }

        // Update an existing officer
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOfficer([FromRoute] int id, [FromBody] Officer officer)
        {
            _logger.LogInformation("Updating officer with ID {Id}", id);
            try
            {
                var existingOfficer = await _firearmDbContext.Officers.FirstOrDefaultAsync(o => o.Id == id);
                if (existingOfficer == null)
                {
                    _logger.LogWarning("Officer with ID {Id} not found", id);
                    return NotFound("Officer not found");
                }

                // Update the properties of the existing officer
                existingOfficer.FullName = officer.FullName;
                existingOfficer.Title = officer.Title;
                existingOfficer.Position = officer.Position;
                existingOfficer.Email = officer.Email;
                existingOfficer.PhoneNumber = officer.PhoneNumber;
                existingOfficer.Description = officer.Description;
                existingOfficer.FirearmType = officer.FirearmType;
                existingOfficer.FirearmModel = officer.FirearmModel;
                existingOfficer.Manufacturer = officer.Manufacturer;
                existingOfficer.FirearmCalibre = officer.FirearmCalibre;
                existingOfficer.YearManufacture = officer.YearManufacture;
                existingOfficer.Source = officer.Source;
                existingOfficer.Holder = officer.Holder;
                existingOfficer.FirearmMechanism = officer.FirearmMechanism;
                existingOfficer.ManufacturerSerial = officer.ManufacturerSerial;
                existingOfficer.RegisteredPosition = officer.RegisteredPosition;
                existingOfficer.RegisteredFullName = officer.RegisteredFullName;
                existingOfficer.RegisteredTitle = officer.RegisteredTitle;
                existingOfficer.RegisteredEmail = officer.RegisteredEmail;
                existingOfficer.RegisteredSignature = officer.RegisteredSignature;
                existingOfficer.RegisteredDate = officer.RegisteredDate;
                existingOfficer.RegisteredBodyFullName = officer.RegisteredBodyFullName;
                existingOfficer.RegisteredBodyResponsibility = officer.RegisteredBodyResponsibility;
                existingOfficer.RegisteredBodySignature = officer.RegisteredBodySignature;
                existingOfficer.RegisteredBodyDate = officer.RegisteredBodyDate;

                await _firearmDbContext.SaveChangesAsync();
                _logger.LogInformation("Officer with ID {Id} updated successfully", id);
                return Ok(existingOfficer);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating officer with ID {Id}", id);
                return StatusCode(500, "Internal server error");
            }
        }

        // Delete an officer by ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOfficer([FromRoute] int id)
        {
            _logger.LogInformation("Deleting officer with ID {Id}", id);
            try
            {
                var officerToDelete = await _firearmDbContext.Officers.FirstOrDefaultAsync(o => o.Id == id);
                if (officerToDelete == null)
                {
                    _logger.LogWarning("Officer with ID {Id} not found", id);
                    return NotFound("Officer not found");
                }

                _firearmDbContext.Officers.Remove(officerToDelete);
                await _firearmDbContext.SaveChangesAsync();
                _logger.LogInformation("Officer with ID {Id} deleted successfully", id);
                return Ok("Officer deleted successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting officer with ID {Id}", id);
                return StatusCode(500, "Internal server error");
            }
        }

        // Get the total number of officers
        [HttpGet("total-officer")]
        public async Task<IActionResult> GetTotalOfficer()
        {
            _logger.LogInformation("Getting the total number of officers");
            try
            {
                var totalOfficers = await _firearmDbContext.Officers.CountAsync();
                return Ok(totalOfficers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting the total number of officers");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
