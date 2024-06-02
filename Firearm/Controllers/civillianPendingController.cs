using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Firearm.Controllers.Models;
using System.Threading.Tasks;
using Firearm.Data;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CivillianPendingController : ControllerBase
    {
        private readonly FirearmDbContext _context;

        public CivillianPendingController(FirearmDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCivillianPending()
        {
            var civilians = await _context.civillianPendings.ToListAsync();
            return Ok(civilians);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCivillianPending([FromRoute] int id)
        {
            var civilian = await _context.civillianPendings.FindAsync(id);
            if (civilian == null)
            {
                return NotFound("Civilian pending not found");
            }
            return Ok(civilian);
        }

        [HttpPost]
        public async Task<IActionResult> AddCivillianPending([FromBody] civillianPending civilian)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _context.civillianPendings.AddAsync(civilian);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetCivillianPending), new { id = civilian.Id }, civilian);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while adding the civilian pending: " + ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCivillianPending([FromRoute] int id, [FromBody] civillianPending civilian)
        {
            if (id != civilian.Id)
            {
                return BadRequest("ID mismatch");
            }

            var existingCivilian = await _context.civillianPendings.FindAsync(id);
            if (existingCivilian == null)
            {
                return NotFound("Civilian pending not found");
            }

            existingCivilian.Fullname = civilian.Fullname;
            existingCivilian.Nationality = civilian.Nationality;
            existingCivilian.DateOfBirth = civilian.DateOfBirth;
            existingCivilian.Sex = civilian.Sex;
            existingCivilian.AcadamicStatus = civilian.AcadamicStatus;
            existingCivilian.MartialStatus = civilian.MartialStatus;
            existingCivilian.MedicalStatus = civilian.MedicalStatus;
            existingCivilian.Occupation = civilian.Occupation;
            existingCivilian.SizeOfCapital = civilian.SizeOfCapital;
            existingCivilian.State = civilian.State;
            existingCivilian.Subcity = civilian.Subcity;
            existingCivilian.District = civilian.District;
            existingCivilian.Kebele = civilian.Kebele;
            existingCivilian.SpecificArea = civilian.SpecificArea;
            existingCivilian.PassportId = civilian.PassportId;
            existingCivilian.phonenumber = civilian.phonenumber;
            existingCivilian.homenumber = civilian.homenumber;
            existingCivilian.ManufacturerSerial = civilian.ManufacturerSerial;
            existingCivilian.IsFirearm = civilian.IsFirearm;
            existingCivilian.DateMarked = civilian.DateMarked;
            existingCivilian.MarkedBy = civilian.MarkedBy;
            existingCivilian.FirearmType = civilian.FirearmType;
            existingCivilian.FirearmModel = civilian.FirearmModel;
            existingCivilian.FirearmMechanism = civilian.FirearmMechanism;
            existingCivilian.FirearmCalibre = civilian.FirearmCalibre;
            existingCivilian.MagazineCapacity = civilian.MagazineCapacity;
            existingCivilian.Manufacturer = civilian.Manufacturer;
            existingCivilian.YearManufacture = civilian.YearManufacture;
            existingCivilian.Source = civilian.Source;
            existingCivilian.Store = civilian.Store;
            existingCivilian.AdditionalComment = civilian.AdditionalComment;
            existingCivilian.holder = civilian.holder;
            existingCivilian.RegisteredPosition = civilian.RegisteredPosition;
            existingCivilian.RegisteredFullName = civilian.RegisteredFullName;
            existingCivilian.RegisteredTitle = civilian.RegisteredTitle;
            existingCivilian.RegisteredSignature = civilian.RegisteredSignature;
            existingCivilian.RegisteredDate = civilian.RegisteredDate;
            existingCivilian.RegisteredBodyFullName = civilian.RegisteredBodyFullName;
            existingCivilian.RegisteredBodyResponsibility = civilian.RegisteredBodyResponsibility;
            existingCivilian.RegisteredBodySignature = civilian.RegisteredBodySignature;
            existingCivilian.RegisteredBodyDate = civilian.RegisteredBodyDate;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(existingCivilian);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating the civilian pending: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCivillianPending([FromRoute] int id)
        {
            var civilian = await _context.civillianPendings.FindAsync(id);
            if (civilian == null)
            {
                return NotFound("Civilian pending not found");
            }

            try
            {
                _context.civillianPendings.Remove(civilian);
                await _context.SaveChangesAsync();
                return Ok("Civilian pending deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting the civilian pending: " + ex.Message);
            }
        }
    }
}
