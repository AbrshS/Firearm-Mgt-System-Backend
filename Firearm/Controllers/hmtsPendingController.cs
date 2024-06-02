using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Firearm.Controllers.Models;
using System.Threading.Tasks;
using Firearm.Data;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HmtsPendingController : ControllerBase
    {
        private readonly FirearmDbContext _context;

        public HmtsPendingController(FirearmDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHmtsPending()
        {
            var hmts = await _context.hmtsPendings.ToListAsync();
            return Ok(hmts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHmTsPending([FromRoute] int id)
        {
            var hmt = await _context.hmtsPendings.FindAsync(id);
            if (hmt == null)
            {
                return NotFound("Hmts pending not found");
            }
            return Ok(hmt);
        }

        [HttpPost]
        public async Task<IActionResult> AddHmTsPending([FromBody] hmtsPending hmt)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _context.hmtsPendings.AddAsync(hmt);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetHmTsPending), new { id = hmt.Id }, hmt);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while adding the hmts pending: " + ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHmTsPending([FromRoute] int id, [FromBody] hmtsPending hmt)
        {
            if (id != hmt.Id)
            {
                return BadRequest("ID mismatch");
            }

            var existingHmTs = await _context.hmtsPendings.FindAsync(id);
            if (existingHmTs == null)
            {
                return NotFound("Hmts pending not found");
            }

            existingHmTs.CountryOfOrigin = hmt.CountryOfOrigin;
            existingHmTs.LicensedCountry = hmt.LicensedCountry;
            existingHmTs.LevelOfService = hmt.LevelOfService;
            existingHmTs.Subcity = hmt.Subcity;
            existingHmTs.District = hmt.District;
            existingHmTs.kebele = hmt.kebele;
            existingHmTs.SpecificArea = hmt.SpecificArea;
            existingHmTs.PassportNo = hmt.PassportNo;
            existingHmTs.PhoneNumber = hmt.PhoneNumber;
            existingHmTs.Email = hmt.Email;
            existingHmTs.ManufacturerSerial = hmt.ManufacturerSerial;
            existingHmTs.IsFirearm = hmt.IsFirearm;
            existingHmTs.DateMarked = hmt.DateMarked;
            existingHmTs.MarkedBy = hmt.MarkedBy;
            existingHmTs.FirearmType = hmt.FirearmType;
            existingHmTs.FirearmModel = hmt.FirearmModel;
            existingHmTs.FirearmMechanism = hmt.FirearmMechanism;
            existingHmTs.FirearmCalibre = hmt.FirearmCalibre;
            existingHmTs.MagazineCapacity = hmt.MagazineCapacity;
            existingHmTs.Manufacturer = hmt.Manufacturer;
            existingHmTs.YearManufacture = hmt.YearManufacture;
            existingHmTs.Source = hmt.Source;
            existingHmTs.Store = hmt.Store;
            existingHmTs.AdditionalComment = hmt.AdditionalComment;
            existingHmTs.RegisteredPosition = hmt.RegisteredPosition;
            existingHmTs.RegisteredFullName = hmt.RegisteredFullName;
            existingHmTs.RegisteredTitle = hmt.RegisteredTitle;
            existingHmTs.registeredResponsibility = hmt.registeredResponsibility;
            existingHmTs.RegisteredSignature = hmt.RegisteredSignature;
            existingHmTs.RegisteredDate = hmt.RegisteredDate;
            existingHmTs.RegisteredBodyFullName = hmt.RegisteredBodyFullName;
            existingHmTs.RegisteredBodyResponsibility = hmt.RegisteredBodyResponsibility;
            existingHmTs.RegisteredBodySignature = hmt.RegisteredBodySignature;
            existingHmTs.RegisteredBodyDate = hmt.RegisteredBodyDate;
            existingHmTs.holder = hmt.holder;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(existingHmTs);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating the hmts pending: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHmTsPending([FromRoute] int id)
        {
            var hmt = await _context.hmtsPendings.FindAsync(id);
            if (hmt == null)
            {
                return NotFound("Hmts pending not found");
            }

            try
            {
                _context.hmtsPendings.Remove(hmt);
                await _context.SaveChangesAsync();
                return Ok("Hmts pending deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting the hmts pending: " + ex.Message);
            }
        }
    }
}