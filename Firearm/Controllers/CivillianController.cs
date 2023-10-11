using Firearm.Controllers.Models;
using Firearm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CivillianController : Controller
    {    
        private readonly FirearmDbContext firearmDbContext;

        public CivillianController(FirearmDbContext firearmDbContext)
        {
            this.firearmDbContext = firearmDbContext; 
        }

        // Get all Civillians
        [HttpGet]
        public async Task<IActionResult> GetAllCivillian()
        {
            var Cvillian= await firearmDbContext.Civillians.ToListAsync();
            return Ok(Cvillian);
        }

        // Get single firearm using the new Guid ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCivillian([FromRoute] int id)
        {
            var Civillian = await firearmDbContext.Civillians.FirstOrDefaultAsync(f => f.Id == id);
            if (Civillian == null)
            {
                return NotFound("Officer not Found");
            }
            return Ok(Civillian);
        }

        //add a new civillian with a new Guid ID

        [HttpPost] 
        public async Task<IActionResult> AddCivillian([FromBody] Firearm.Controllers.Models.Civillian civillian)
        {
            try
            {

                await firearmDbContext.Civillians.AddAsync(civillian);
                await firearmDbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(AddCivillian), new { id = civillian.Id }, civillian);
            }
            catch (Exception ex)
            {
                // Handle the exception and return an error response
                return StatusCode(500, "An error occurred while adding the new civllian: " + ex.Message);
            }

        }
        // Update a firearm using the new Guid ID
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCivillian([FromRoute] int id, [FromBody] Firearm.Controllers.Models.Civillian civillian)
        {
            var existingCivillian = await firearmDbContext.Firearms.FirstOrDefaultAsync(f => f.Id == id);
            if (existingCivillian != null)
            {
                // Update the properties of the existing firearm


                // Update other propertes here

                await firearmDbContext.SaveChangesAsync();
                return Ok(existingCivillian);
            }
            return NotFound("Officer Not Found");
        }

        // Implement other actions such as Delete, if needed

        // Delete a firearm using the new Guid ID

        // Delete an officer by ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCivillian([FromRoute] int id)
        {
            var civillianToDelete = await firearmDbContext.Civillians.FirstOrDefaultAsync(f => f.Id == id);
            if (civillianToDelete != null)
            {
                try
                {
                    firearmDbContext.Civillians.Remove(civillianToDelete);
                    await firearmDbContext.SaveChangesAsync();
                    return Ok("Civillian deleted successfully");
                }
                catch (Exception ex)
                {
                    // Handle the exception and return an error response
                    return StatusCode(500, "An error occurred while deleting the civillian: " + ex.Message);
                }
            }
            return NotFound("Civillian Not Found");
        }

        [HttpGet("total-civillian")]
        public async Task<IActionResult> GetTotalFirearms()
        {
            var totalCivillians = await firearmDbContext.Civillians.CountAsync();
            return Ok(totalCivillians);
        }

    }
}
