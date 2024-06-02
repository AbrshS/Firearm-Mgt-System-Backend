using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Firearm.Controllers.Models;
using System.Threading.Tasks;
using Firearm.Data;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DistructionPendingController : ControllerBase
    {
        private readonly FirearmDbContext _context;

        public DistructionPendingController(FirearmDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDistructionPending()
        {
            var distructions = await _context.distructionPendings.ToListAsync();
            return Ok(distructions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDistructionPending([FromRoute] int id)
        {
            var distruction = await _context.distructionPendings.FindAsync(id);
            if (distruction == null)
            {
                return NotFound("Destruction pending not found");
            }
            return Ok(distruction);
        }

        [HttpPost]
        public async Task<IActionResult> AddDistructionPending([FromBody] distructionPending distruction)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                distruction.DateDestroyed = DateTime.UtcNow;
                await _context.distructionPendings.AddAsync(distruction);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetDistructionPending), new { id = distruction.Id }, distruction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while adding the destruction pending: " + ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDistructionPending([FromRoute] int id, [FromBody] distructionPending distruction)
        {
            if (id != distruction.Id)
            {
                return BadRequest("ID mismatch");
            }

            var existingDistruction = await _context.distructionPendings.FindAsync(id);
            if (existingDistruction == null)
            {
                return NotFound("Destruction pending not found");
            }

            existingDistruction.DestructionDate = distruction.DestructionDate;
            existingDistruction.DestructionRequestedBy = distruction.DestructionRequestedBy;
            existingDistruction.ReasonForDestruction = distruction.ReasonForDestruction;
            existingDistruction.AuthorizedBy = distruction.AuthorizedBy;
            existingDistruction.ManufacturerSerial = distruction.ManufacturerSerial;
            existingDistruction.IsFirearm = distruction.IsFirearm;
            existingDistruction.DateMarked = distruction.DateMarked;
            existingDistruction.MarkedBy = distruction.MarkedBy;
            existingDistruction.FirearmType = distruction.FirearmType;
            existingDistruction.FirearmModel = distruction.FirearmModel;
            existingDistruction.FirearmMechanism = distruction.FirearmMechanism;
            existingDistruction.FirearmCalibre = distruction.FirearmCalibre;
            existingDistruction.MagazineCapacity = distruction.MagazineCapacity;
            existingDistruction.Manufacturer = distruction.Manufacturer;
            existingDistruction.YearManufacture = distruction.YearManufacture;
            existingDistruction.Source = distruction.Source;
            existingDistruction.Store = distruction.Store;
            existingDistruction.AdditionalComment = distruction.AdditionalComment;
            existingDistruction.AuthorizationDate = distruction.AuthorizationDate;
            existingDistruction.DateDestroyed = distruction.DateDestroyed;
            existingDistruction.holder = distruction.holder;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(existingDistruction);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating the destruction pending: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDistructionPending([FromRoute] int id)
        {
            var distruction = await _context.distructionPendings.FindAsync(id);
            if (distruction == null)
            {
                return NotFound("Destruction pending not found");
            }

            try
            {
                _context.distructionPendings.Remove(distruction);
                await _context.SaveChangesAsync();
                return Ok("Destruction pending deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting the destruction pending: " + ex.Message);
            }
        }
    }
}