using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Firearm.Controllers.Models;
using System.Threading.Tasks;
using Firearm.Data;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecoverPendingController : ControllerBase
    {
        private readonly FirearmDbContext _context;

        public RecoverPendingController(FirearmDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRecoverPending()
        {
            var recovers = await _context.recoverPendings.ToListAsync();
            return Ok(recovers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecoverPending([FromRoute] int id)
        {
            var recover = await _context.recoverPendings.FindAsync(id);
            if (recover == null)
            {
                return NotFound("Recover pending not found");
            }
            return Ok(recover);
        }

        [HttpPost]
        public async Task<IActionResult> AddRecoverPending([FromBody] recoverPending recover)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _context.recoverPendings.AddAsync(recover);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetRecoverPending), new { id = recover.Id }, recover);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while adding the recover pending: " + ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRecoverPending([FromRoute] int id, [FromBody] recoverPending recover)
        {
            if (id != recover.Id)
            {
                return BadRequest("ID mismatch");
            }

            var existingRecover = await _context.recoverPendings.FindAsync(id);
            if (existingRecover == null)
            {
                return NotFound("Recover pending not found");
            }

            existingRecover.FirearmReturnedTo = recover.FirearmReturnedTo;
            existingRecover.ReportedBy = recover.ReportedBy;
            existingRecover.AuthorizedBy = recover.AuthorizedBy;
            existingRecover.AuthorizedDate = recover.AuthorizedDate;
            existingRecover.ReasonToReturn = recover.ReasonToReturn;
            existingRecover.Status = recover.Status;
            existingRecover.ManufacturerSerial = recover.ManufacturerSerial;
            existingRecover.IsFirearm = recover.IsFirearm;
            existingRecover.DateMarked = recover.DateMarked;
            existingRecover.MarkedBy = recover.MarkedBy;
            existingRecover.FirearmType = recover.FirearmType;
            existingRecover.FirearmModel = recover.FirearmModel;
            existingRecover.FirearmMechanism = recover.FirearmMechanism;
            existingRecover.FirearmCalibre = recover.FirearmCalibre;
            existingRecover.MagazineCapacity = recover.MagazineCapacity;
            existingRecover.Manufacturer = recover.Manufacturer;
            existingRecover.YearManufacture = recover.YearManufacture;
            existingRecover.Source = recover.Source;
            existingRecover.Store = recover.Store;
            existingRecover.AdditionalComment = recover.AdditionalComment;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(existingRecover);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating the recover pending: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecoverPending([FromRoute] int id)
        {
            var recover = await _context.recoverPendings.FindAsync(id);
            if (recover == null)
            {
                return NotFound("Recover pending not found");
            }

            try
            {
                _context.recoverPendings.Remove(recover);
                await _context.SaveChangesAsync();
                return Ok("Recover pending deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting the recover pending: " + ex.Message);
            }
        }
    }
}