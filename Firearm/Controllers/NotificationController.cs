using Firearm.Controllers.Models;
using Firearm.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class NotificationController : ControllerBase
{
    private readonly FirearmDbContext _firearmDbContext;
    private readonly ILogger<NotificationController> _logger;

    public NotificationController(FirearmDbContext firearmDbContext, ILogger<NotificationController> logger)
    {
        _firearmDbContext = firearmDbContext;
        _logger = logger;
    }
     

    [HttpGet]
 
    public async Task<IActionResult> GetNotifications()
    {
        try
        {
            var notifications = await _firearmDbContext.notifications.ToListAsync();
            return Ok(notifications);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while getting notifications");
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("count")]
  
    public async Task<IActionResult> GetNotificationsCount()
    {
        try
        {
            var count = await _firearmDbContext.notifications.CountAsync();
            return Ok(count);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while counting notifications");
            return StatusCode(500, "Internal server error");
        }
    }


    [HttpPut("markAsRead/{id}")]

    public async Task<IActionResult> MarkAsRead(int id)
    {
        try
        {
            var notification = await _firearmDbContext.notifications.FindAsync(id);
            if (notification == null)
            {
                return NotFound();
            }

            notification.IsRead = true;
            await _firearmDbContext.SaveChangesAsync();
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while marking notification as read");
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpDelete("{id}")]

    public async Task<IActionResult> DeleteNotification(int id)
    {
        try
        {
            var notification = await _firearmDbContext.notifications.FindAsync(id);
            if (notification == null)
            {
                return NotFound();
            }

            _firearmDbContext.notifications.Remove(notification);
            await _firearmDbContext.SaveChangesAsync();
            return Ok(new { Message = "Notification Deleted  successfully!" });   
        }    
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while deleting notification");
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpPost]
    
    public async Task<IActionResult> PostNotification([FromBody] Notification notification)
    {
        try
        {     
            // Add the new notification to the database
            _firearmDbContext.notifications.Add(notification);
            await _firearmDbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNotifications), notification);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while posting notification");
            return StatusCode(500, "Internal server error");
        }
    }

}