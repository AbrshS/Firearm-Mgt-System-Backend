using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Firearm.Controllers.Models;
using System.Threading.Tasks;
using Firearm.Data;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PoagPendingController : ControllerBase
    {
        private readonly FirearmDbContext _context;

        public PoagPendingController(FirearmDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPoagPending()
        {
            var poags = await _context.poagPendings.ToListAsync();
            return Ok(poags);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPoagPending([FromRoute] int id)
        {
            var poag = await _context.poagPendings.FindAsync(id);
            if (poag == null)
            {
                return NotFound("Poag pending not found");
            }
            return Ok(poag);
        }

        [HttpPost]
        public async Task<IActionResult> AddPoagPending([FromBody] poagPending poag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _context.poagPendings.AddAsync(poag);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetPoagPending), new { id = poag.Id }, poag);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while adding the poag pending: " + ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePoagPending([FromRoute] int id, [FromBody] poagPending poag)
        {
            if (id != poag.Id)
            {
                return BadRequest("ID mismatch");
            }

            var existingPoag = await _context.poagPendings.FindAsync(id);
            if (existingPoag == null)
            {
                return NotFound("Poag pending not found");
            }

            existingPoag.NameOfOrganisation = poag.NameOfOrganisation;
            existingPoag.sector = poag.sector;
            existingPoag.SizeOfCapital = poag.SizeOfCapital;
            existingPoag.Region = poag.Region;
            existingPoag.Subcity = poag.Subcity;
            existingPoag.District = poag.District;
            existingPoag.kebele = poag.kebele;
            existingPoag.SpecificArea = poag.SpecificArea;
            existingPoag.PhoneNumber = poag.PhoneNumber;
            existingPoag.Email = poag.Email;
            existingPoag.ManufacturerSerial = poag.ManufacturerSerial;
            existingPoag.IsFirearm = poag.IsFirearm;
            existingPoag.DateMarked = poag.DateMarked;
            existingPoag.MarkedBy = poag.MarkedBy;
            existingPoag.FirearmType = poag.FirearmType;
            existingPoag.FirearmModel = poag.FirearmModel;
            existingPoag.FirearmMechanism = poag.FirearmMechanism;
            existingPoag.FirearmCalibre = poag.FirearmCalibre;
            existingPoag.MagazineCapacity = poag.MagazineCapacity;
            existingPoag.Manufacturer = poag.Manufacturer;
            existingPoag.YearManufacture = poag.YearManufacture;
            existingPoag.Source = poag.Source;
            existingPoag.Store = poag.Store;
            existingPoag.AdditionalComment = poag.AdditionalComment;
            existingPoag.RegisteredPosition = poag.RegisteredPosition;
            existingPoag.RegisteredFullName = poag.RegisteredFullName;
            existingPoag.RegisteredTitle = poag.RegisteredTitle;
            existingPoag.registeredResponsibility = poag.registeredResponsibility;
            existingPoag.RegisteredSignature = poag.RegisteredSignature;
            existingPoag.RegisteredDate = poag.RegisteredDate;
            existingPoag.RegisteredBodyFullName = poag.RegisteredBodyFullName;
            existingPoag.RegisteredBodyResponsibility = poag.RegisteredBodyResponsibility;
            existingPoag.RegisteredBodySignature = poag.RegisteredBodySignature;
            existingPoag.RegisteredBodyDate = poag.RegisteredBodyDate;
            existingPoag.holder = poag.holder;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(existingPoag);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating the poag pending: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePoagPending([FromRoute] int id)
        {
            var poag = await _context.poagPendings.FindAsync(id);
            if (poag == null)
            {
                return NotFound("Poag pending not found");
            }

            try
            {
                _context.poagPendings.Remove(poag);
                await _context.SaveChangesAsync();
                return Ok("Poag pending deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting the poag pending: " + ex.Message);
            }
        }
    }
}