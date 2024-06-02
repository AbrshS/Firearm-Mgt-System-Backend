using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Firearm.Controllers.Models;
using System.Threading.Tasks;
using Firearm.Data;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IofcPendingController : ControllerBase
    {
        private readonly FirearmDbContext _context;

        public IofcPendingController(FirearmDbContext context)
        {
            _context = context;
        }
         
        [HttpGet]  
        public async Task<IActionResult> GetAllIofcPending()
        {
            var iofcPendings = await _context.iofcPendings.ToListAsync();
            return Ok(iofcPendings);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetIofcPending([FromRoute] int id)
        {
            var iofcPending = await _context.iofcPendings.FindAsync(id);
            if (iofcPending == null)
            {
                return NotFound("Iofc pending not found");
            }
            return Ok(iofcPending);
        }

        [HttpPost]
        public async Task<IActionResult> AddIofcPending([FromBody] iofcPending iofcPending)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _context.iofcPendings.AddAsync(iofcPending);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetIofcPending), new { id = iofcPending.Id }, iofcPending);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while adding the iofc pending: " + ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateIofcPending([FromRoute] int id, [FromBody] iofcPending iofcPending)
        {
            if (id != iofcPending.Id)
            {
                return BadRequest("ID mismatch");
            }

            var existingIofcPending = await _context.iofcPendings.FindAsync(id);
            if (existingIofcPending == null)
            {
                return NotFound("Iofc pending not found");
            }

            existingIofcPending.FullName = iofcPending.FullName;
            existingIofcPending.CandidateCountry = iofcPending.CandidateCountry;
            existingIofcPending.EvidenceOfMedical = iofcPending.EvidenceOfMedical;
            existingIofcPending.PassportNo = iofcPending.PassportNo;
            existingIofcPending.ReasonHeCame = iofcPending.ReasonHeCame;
            existingIofcPending.ComingDate = iofcPending.ComingDate;
            existingIofcPending.CountryOfResidence = iofcPending.CountryOfResidence;
            existingIofcPending.Region = iofcPending.Region;
            existingIofcPending.Subcity = iofcPending.Subcity;
            existingIofcPending.District = iofcPending.District;
            existingIofcPending.kebele = iofcPending.kebele;
            existingIofcPending.SpecificArea = iofcPending.SpecificArea;
            existingIofcPending.PhoneNumber = iofcPending.PhoneNumber;
            existingIofcPending.Email = iofcPending.Email;
            existingIofcPending.ManufacturerSerial = iofcPending.ManufacturerSerial;
            existingIofcPending.IsFirearm = iofcPending.IsFirearm;
            existingIofcPending.DateMarked = iofcPending.DateMarked;
            existingIofcPending.MarkedBy = iofcPending.MarkedBy;
            existingIofcPending.FirearmType = iofcPending.FirearmType;
            existingIofcPending.FirearmModel = iofcPending.FirearmModel;
            existingIofcPending.FirearmMechanism = iofcPending.FirearmMechanism;
            existingIofcPending.FirearmCalibre = iofcPending.FirearmCalibre;
            existingIofcPending.MagazineCapacity = iofcPending.MagazineCapacity;
            existingIofcPending.Manufacturer = iofcPending.Manufacturer;
            existingIofcPending.YearManufacture = iofcPending.YearManufacture;
            existingIofcPending.Source = iofcPending.Source;
            existingIofcPending.Store = iofcPending.Store;
            existingIofcPending.AdditionalComment = iofcPending.AdditionalComment;
            existingIofcPending.RegisteredPosition = iofcPending.RegisteredPosition;
            existingIofcPending.RegisteredFullName = iofcPending.RegisteredFullName;
            existingIofcPending.RegisteredTitle = iofcPending.RegisteredTitle;
            existingIofcPending.registeredResponsibility = iofcPending.registeredResponsibility;
            existingIofcPending.RegisteredSignature = iofcPending.RegisteredSignature;
            existingIofcPending.RegisteredDate = iofcPending.RegisteredDate;
            existingIofcPending.RegisteredBodyFullName = iofcPending.RegisteredBodyFullName;
            existingIofcPending.RegisteredBodyResponsibility = iofcPending.RegisteredBodyResponsibility;
            existingIofcPending.RegisteredBodySignature = iofcPending.RegisteredBodySignature;
            existingIofcPending.RegisteredBodyDate = iofcPending.RegisteredBodyDate;
            existingIofcPending.holder = iofcPending.holder;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(existingIofcPending);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating the iofc pending: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIofcPending([FromRoute] int id)
        {
            var iofcPending = await _context.iofcPendings.FindAsync(id);
            if (iofcPending == null)
            {
                return NotFound("Iofc pending not found");
            }

            try
            {
                _context.iofcPendings.Remove(iofcPending);
                await _context.SaveChangesAsync();
                return Ok("Iofc pending deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting the iofc pending: " + ex.Message);
            }
        }
    }
}
