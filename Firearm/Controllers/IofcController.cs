using Firearm.Controllers.Models;
using Firearm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IofcController : Controller

    {


        private readonly FirearmDbContext firearmDbContext;

        public IofcController(FirearmDbContext firearmDbContext)
        {
            this.firearmDbContext = firearmDbContext;
        }

        // Get all Firearms
        [HttpGet]
        public async Task<IActionResult> GetAllIofcs()
        {
            var iofcs = await firearmDbContext.iofcs.ToListAsync();
            return Ok(iofcs);
        }

        // Get single organisation using the new ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetIofc([FromRoute] int id)
        {
            var iofc = await firearmDbContext.iofcs.FirstOrDefaultAsync(f => f.Id == id);
            if (iofc == null)
            {
                return NotFound("Firearm not Found");
            }
            return Ok(iofc);
        }


        // // add a private and govermental organisation with a new  ID
        [HttpPost]
        public async Task<IActionResult> AddIofc([FromBody] Iofc iofc)
        {
            try
            {

                await firearmDbContext.iofcs.AddAsync(iofc);
                await firearmDbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(AddIofc), new { id = iofc.Id }, iofc);
            }
            catch (Exception ex)
            {
                // Handle the exception and return an error response
                return StatusCode(500, "An error occurred while adding: " + ex.Message);
            }

        }


        //delete the organisation  
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIofc([FromRoute] int id)
        {
            var iofcToDelete = await firearmDbContext.iofcs.FirstOrDefaultAsync(f => f.Id == id);

            if (iofcToDelete == null)
            {
                return NotFound("Iofc not found");
            }

            try
            {
                firearmDbContext.iofcs.Remove(iofcToDelete);
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
