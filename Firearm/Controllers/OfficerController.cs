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
    public class OfficerController : Controller
    {
        private readonly FirearmDbContext firearmDbContext;

        public OfficerController(FirearmDbContext firearmDbContext)
        {
            this.firearmDbContext = firearmDbContext;
        }

        // Get all Officers
        [HttpGet]
        public async Task<IActionResult> GetAllOfficer()
        {
            var Officer = await firearmDbContext.Officers.ToListAsync();
            return Ok(Officer);
        }

        // Get single firearm using the new Guid ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOfficer([FromRoute] int id)
        {
            var Officer = await firearmDbContext.Officers.FirstOrDefaultAsync(f => f.Id == id);
            if (Officer == null)
            {
                return NotFound("Officer not Found");
            }
            return Ok(Officer);
        }

        // Add a firearm with a new Guid ID
        [HttpPost]
        public async Task<IActionResult> AddOfficer([FromBody] Firearm.Controllers.Models.Officer officer)
        {
            try
            {
                //firearm.Id = Guid.NewGuid(); // Generate a new Guid for the ID
                await firearmDbContext.Officers.AddAsync(officer);
                await firearmDbContext.SaveChangesAsync();
                return CreatedAtAction(nameof(AddOfficer), new { id = officer.Id }, officer);
            }
            catch (Exception ex)
            {
                // Handle the exception and return an error response
                return StatusCode(500, "An error occurred while adding the firearm: " + ex.Message);
            }

        }

        // Update a firearm using the new Guid ID
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOfficer([FromRoute] int id, [FromBody] Firearm.Controllers.Models.Officer officer)
        {
            var existingOfficer = await firearmDbContext.Firearms.FirstOrDefaultAsync(f => f.Id == id);
            if (existingOfficer != null)
            {
                // Update the properties of the existing firearm
              

                // Update other propertes here

                await firearmDbContext.SaveChangesAsync();
                return Ok(existingOfficer);
            }
            return NotFound("Officer Not Found");
        }

        // Implement other actions such as Delete, if needed

        // Delete a firearm using the new Guid ID


    }
}