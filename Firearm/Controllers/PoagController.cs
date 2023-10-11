using Firearm.Controllers.Models;
using Firearm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PoagController : Controller 

    {
        

        private readonly FirearmDbContext firearmDbContext;

        public PoagController(FirearmDbContext firearmDbContext)
        {
            this.firearmDbContext = firearmDbContext;
        }

        // Get all Firearms
        [HttpGet]
        public async Task<IActionResult> GetAllPoages()
        {
            var Poages = await firearmDbContext.Poages.ToListAsync();
            return Ok(Poages);
        }

        // Get single organisation using the new ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPoag([FromRoute] int id)
        {
            var Poag = await firearmDbContext.Poages.FirstOrDefaultAsync(f => f.Id == id);
            if (Poag == null)
            {
                return NotFound("Firearm not Found");
            }
            return Ok(Poag);
        }


        // // add a private and govermental organisation with a new  ID
        [HttpPost]
        public async Task<IActionResult> AddPoag([FromBody] Poag poag)
        {
            try
            {
                
                await firearmDbContext.Poages.AddAsync(poag);
                await firearmDbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(AddPoag), new { id = poag.Id }, poag);
            }
            catch (Exception ex)
            {
                // Handle the exception and return an error response
                return StatusCode(500, "An error occurred while adding the organisation: " + ex.Message);
            }

        }


        //delete the organisation  
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePoag([FromRoute] int id)
        {
            var poagToDelete = await firearmDbContext.Poages.FirstOrDefaultAsync(f => f.Id == id);

            if (poagToDelete == null)
            {
                return NotFound("Poag not found");
            }

            try
            {
                firearmDbContext.Poages.Remove(poagToDelete);
                await firearmDbContext.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                // Consider returning a more detailed error message for production
                return StatusCode(500, "An error occurred while deleting the organisation: " + ex.Message);
            }
        }

        //
    }
}
