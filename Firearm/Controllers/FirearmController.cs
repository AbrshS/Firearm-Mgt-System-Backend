using Firearm.Controllers.Models;
using Firearm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks; 



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
        [HttpGet]
        public async Task<IActionResult> GetAllFirearms()
        {
            var Firearms = await firearmDbContext.Firearms.ToListAsync();
            return Ok(Firearms);
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
                //firearm.Id = Guid.NewGuid(); // Generate a new Guid for the ID
                await firearmDbContext.Firearms.AddAsync(firearm);
                await firearmDbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(AddFirearm), new { id = firearm.Id }, firearm);
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
                existingFirearm.DateMarked =  firearm.DateMarked;
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
         


    }
}  