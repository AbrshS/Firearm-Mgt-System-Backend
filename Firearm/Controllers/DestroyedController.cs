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
    public class DestroyedController : Controller
    {
        private readonly FirearmDbContext firearmDbContext;

        public DestroyedController(FirearmDbContext firearmDbContext)
        {
            this.firearmDbContext = firearmDbContext;
        }


        // Get all Lost Firearms
        [HttpGet]
        public async Task<IActionResult> GetAllDestroyed()
        {
            var Destroyeds = await firearmDbContext.Destroyeds.ToListAsync();
            return Ok(Destroyeds);
        }


        // Get single firearm using the id 

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllDestroyed([FromRoute] int id)
        {
            var Destroyeds = await firearmDbContext.Destroyeds.FirstOrDefaultAsync(f => f.Id == id);
            if (Destroyeds == null)
            {
                return NotFound("Destroyed firearm not Found");
            }
            return Ok(Destroyeds);
        }


        // Add a lost firearm with a new integer id 
        [HttpPost]
        public async Task<IActionResult> AddDestroyed([FromBody] Firearm.Controllers.Models.Destroyed destroyed)
        {
            try
            {

                await firearmDbContext.Destroyeds.AddAsync(destroyed);
                await firearmDbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(AddDestroyed), new { id = destroyed.Id }, destroyed);
            }
            catch (Exception ex)
            {
                // Handle the exception and return an error response
                return StatusCode(500, "An error occurred while adding the lost firearm: " + ex.Message);
            }

        }

        // Update a loss firearm using the new id
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDestroyed([FromRoute] int id, [FromBody] Firearm.Controllers.Models.Destroyed loss)
        {
            var existingDestroyed = await firearmDbContext.Firearms.FirstOrDefaultAsync(f => f.Id == id);
            if (existingDestroyed != null)
            {
                // Update the properties of the existing firearm


                // Update other propertes here

                await firearmDbContext.SaveChangesAsync();
                return Ok(existingDestroyed);
            }
            return NotFound("Destroyed Not Found");
        }





        // Delete an lossfirearm by ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestroyed([FromRoute] int id)
        { 
            var DestroyedToDelete = await firearmDbContext.Destroyeds.FirstOrDefaultAsync(f => f.Id == id);
            if (DestroyedToDelete != null)
            {
                try
                {                                                     
                    firearmDbContext.Destroyeds.Remove(DestroyedToDelete);
                    await firearmDbContext.SaveChangesAsync();
                    return Ok("Destroyed firearm deleted successfully");
                } 

                catch (Exception ex)
                {
                    // Handle the exception and return an error response
                    return StatusCode(500, "An error occurred while deleting the lost firearm: " + ex.Message);
                }
            }
            return NotFound("lost firearm Not Found");
        }

        [HttpGet("total-destroyed")]
        public async Task<IActionResult> GetTotalDestroyedFirearms()
        {
            var totaldestroyed = await firearmDbContext.Destroyeds.CountAsync();
            return Ok(totaldestroyed);
        }

    }
}
              