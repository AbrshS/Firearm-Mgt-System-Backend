using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Firearm.Controllers.Models;
using System.Threading.Tasks;
using Firearm.Data;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LossPendingController : ControllerBase
    {
        private readonly FirearmDbContext _context;

        public LossPendingController(FirearmDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLossPending()
        {
            var losses = await _context.losspendings.ToListAsync();
            return Ok(losses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLossPending([FromRoute] int id)
        {
            var loss = await _context.losspendings.FindAsync(id);
            if (loss == null)
            {
                return NotFound("Loss pending not found");
            }
            return Ok(loss);
        }

        [HttpPost]
        public async Task<IActionResult> AddLossPending([FromBody] lossPending loss)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                loss.DateLost = DateTime.UtcNow;
                await _context.losspendings.AddAsync(loss);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetLossPending), new { id = loss.Id }, loss);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while adding the loss pending: " + ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLossPending([FromRoute] int id, [FromBody] lossPending loss)
        {
            if (id != loss.Id)
            {
                return BadRequest("ID mismatch");
            }

            var existingLoss = await _context.losspendings.FindAsync(id);
            if (existingLoss == null)
            {
                return NotFound("Loss pending not found");
            }

            existingLoss.FullName = loss.FullName;
            existingLoss.FpId = loss.FpId;
            existingLoss.ManufacturerSerial = loss.ManufacturerSerial;
            existingLoss.IsFirearm = loss.IsFirearm;
            existingLoss.DateMarked = loss.DateMarked;
            existingLoss.MarkedBy = loss.MarkedBy;
            existingLoss.FirearmType = loss.FirearmType;
            existingLoss.FirearmModel = loss.FirearmModel;
            existingLoss.FirearmMechanism = loss.FirearmMechanism;
            existingLoss.FirearmCalibre = loss.FirearmCalibre;
            existingLoss.MagazineCapacity = loss.MagazineCapacity;
            existingLoss.Manufacturer = loss.Manufacturer;
            existingLoss.YearManufacture = loss.YearManufacture;
            existingLoss.Source = loss.Source;
            existingLoss.Store = loss.Store;
            existingLoss.holder = loss.holder;
            existingLoss.AdditionalComment = loss.AdditionalComment;
            existingLoss.ReportedOn = loss.ReportedOn;
            existingLoss.Comment = loss.Comment;
            existingLoss.DateLost = loss.DateLost;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(existingLoss);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating the loss pending: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLossPending([FromRoute] int id)
        {
            var loss = await _context.losspendings.FindAsync(id);
            if (loss == null)
            {
                return NotFound("Loss pending not found");
            }

            try
            {
                _context.losspendings.Remove(loss);
                await _context.SaveChangesAsync();
                return Ok("Loss pending deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting the loss pending: " + ex.Message);
            }
        }
    }
}
