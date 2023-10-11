using Firearm.Controllers.Models;
using Firearm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Firearm.Controllers
{
   
        [ApiController]
        [Route("api/[controller]")]
        public class HmtsController : Controller

        {


            private readonly FirearmDbContext firearmDbContext;

            public HmtsController(FirearmDbContext firearmDbContext)
            {
                this.firearmDbContext = firearmDbContext;
            }

            // Get all Firearms
            [HttpGet]
            public async Task<IActionResult> GetAllHmtss()
            {
                var hmts = await firearmDbContext.hmts.ToListAsync();
                return Ok(hmts);
            }

            // Get single organisation using the new ID
            [HttpGet("{id}")]
            public async Task<IActionResult> GetHmts([FromRoute] int id)
            {
                var Hmts = await firearmDbContext.hmts.FirstOrDefaultAsync(f => f.Id == id);
                if (Hmts == null)
                {
                    return NotFound("Firearm not Found");
                }
                return Ok(Hmts);
            }


            // // add a private and govermental organisation with a new  ID
            [HttpPost]
            public async Task<IActionResult> AddHmts([FromBody] Hmts hmts)
            {
                try
                {

                    await firearmDbContext.hmts.AddAsync(hmts);
                    await firearmDbContext.SaveChangesAsync();
                    return CreatedAtAction(nameof(AddHmts), new { id = hmts.Id }, hmts);
                }
                catch (Exception ex)
                {
                    // Handle the exception and return an error response
                    return StatusCode(500, "An error occurred while adding the organisation: " + ex.Message);
                }

            }


            //delete the organisation  
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteHmts([FromRoute] int id)
            {
                var hmtsToDelete = await firearmDbContext.hmts.FirstOrDefaultAsync(f => f.Id == id);

                if (hmtsToDelete == null)
                {
                    return NotFound("Hmts not found");
                }

                try
                {
                    firearmDbContext.hmts.Remove(hmtsToDelete);
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

