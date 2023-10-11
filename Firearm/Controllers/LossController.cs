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
    public class LossController : Controller
    {
        private readonly FirearmDbContext firearmDbContext;

        public LossController(FirearmDbContext firearmDbContext)
        {
            this.firearmDbContext = firearmDbContext;
        }


        // Get all Lost Firearms
        [HttpGet]
        public async Task<IActionResult> GetAllLosses()
        {
            var Losses = await firearmDbContext.Losses.ToListAsync();
            return Ok(Losses);
        }


        // Get single firearm using the id 

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLosses([FromRoute] int id)
        {
            var Loss = await firearmDbContext.Losses.FirstOrDefaultAsync(f => f.Id == id);
            if (Loss == null)
            {
                return NotFound("Loss firearm not Found");
            }
            return Ok(Loss);
        }


        // Add a lost firearm with a new integer id 
        [HttpPost]
        public async Task<IActionResult> AddLoss([FromBody] Firearm.Controllers.Models.Loss loss)
        {
            try
            {

                await firearmDbContext.Losses.AddAsync(loss);
                await firearmDbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(AddLoss), new { id = loss.Id }, loss);
            }
            catch (Exception ex)
            {
                // Handle the exception and return an error response
                return StatusCode(500, "An error occurred while adding the lost firearm: " + ex.Message);
            }

        }

        // Update a loss firearm using the new id
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLoss([FromRoute] int id, [FromBody] Firearm.Controllers.Models.Loss loss)
        {
            var existingLoss = await firearmDbContext.Losses.FirstOrDefaultAsync(f => f.Id == id);
            if (existingLoss != null)
            {
                // Update the properties of the existing firearm


                // Update other propertes here

                await firearmDbContext.SaveChangesAsync();
                return Ok(existingLoss);
            }
            return NotFound("Officer Not Found");
        }





        // Delete an lossfirearm by ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoss([FromRoute] int id)
        {
            var lossToDelete = await firearmDbContext.Losses.FirstOrDefaultAsync(f => f.Id == id);
            if (lossToDelete != null)
            {
                try
                {
                    firearmDbContext.Losses.Remove(lossToDelete);
                    await firearmDbContext.SaveChangesAsync();
                    return Ok("loss firearm deleted successfully");
                }
                catch (Exception ex)
                {
                    // Handle the exception and return an error response
                    return StatusCode(500, "An error occurred while deleting the lost firearm: " + ex.Message);
                }
            }
            return NotFound("lost firearm Not Found");
        }

        [HttpGet("total-loss")]
        public async Task<IActionResult> GetTotalFirearms()
        {
            var totalLosses = await firearmDbContext.Losses.CountAsync();
            return Ok(totalLosses);
        }

    }
}