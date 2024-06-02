using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Firearm.Data;
using Firearm.Controllers.Models;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WithdrawalsController : ControllerBase
    {
        private readonly FirearmDbContext firearmDbContext;

        public WithdrawalsController(FirearmDbContext firearmDbContext)
        {
            this.firearmDbContext = firearmDbContext;
        }

        // POST api/withdrawals
        [HttpPost]
        public async Task<IActionResult> PostWithdrawal([FromBody] Withdrawal withdrawal)
        {
            try
            {
                // Add the new withdrawal to the database
                firearmDbContext.withdrawals.Add(withdrawal);
                await firearmDbContext.SaveChangesAsync();

                return CreatedAtAction(nameof(PostWithdrawal), withdrawal);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while logging the withdrawal: " + ex.Message);
            }
        }

        // GET api/withdrawals/count/daily
        [HttpGet("count/daily")]
        public async Task<IActionResult> GetDailyWithdrawalsCount()
        {
            try
            {
                var startDate = DateTime.Today;
                var endDate = startDate.AddDays(1);
                var dailyWithdrawalsCount = await firearmDbContext.withdrawals
                    .Where(w => w.WithdrawalDate >= startDate && w.WithdrawalDate < endDate)
                    .CountAsync();

                return Ok(dailyWithdrawalsCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while counting daily withdrawals: " + ex.Message);
            }
        }

        // GET api/withdrawals/count/weekly
        [HttpGet("count/weekly")]
        public async Task<IActionResult> GetWeeklyWithdrawalsCount()
        {
            try
            {
                var startDate = DateTime.Today.AddDays(-7);
                var endDate = DateTime.Today.AddDays(1);
                var weeklyWithdrawalsCount = await firearmDbContext.withdrawals
                    .Where(w => w.WithdrawalDate >= startDate && w.WithdrawalDate < endDate)
                    .CountAsync();

                return Ok(weeklyWithdrawalsCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while counting weekly withdrawals: " + ex.Message);
            }
        }

        // GET api/withdrawals/count/monthly
        [HttpGet("count/monthly")]
        public async Task<IActionResult> GetMonthlyWithdrawalsCount()
        {
            try
            {
                var today = DateTime.Today;
                var startDate = new DateTime(today.Year, today.Month, 1);
                var endDate = startDate.AddMonths(1);
                var monthlyWithdrawalsCount = await firearmDbContext.withdrawals
                    .Where(w => w.WithdrawalDate >= startDate && w.WithdrawalDate < endDate)
                    .CountAsync();

                return Ok(monthlyWithdrawalsCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while counting monthly withdrawals: " + ex.Message);
            }
        }

        // GET api/withdrawals/count/yearly
        [HttpGet("count/yearly")]
        public async Task<IActionResult> GetYearlyWithdrawalsCount()
        {
            try
            {
                var today = DateTime.Today;
                var startDate = new DateTime(today.Year, 1, 1);
                var endDate = startDate.AddYears(1);
                var yearlyWithdrawalsCount = await firearmDbContext.withdrawals
                    .Where(w => w.WithdrawalDate >= startDate && w.WithdrawalDate < endDate)
                    .CountAsync();

                return Ok(yearlyWithdrawalsCount);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while counting yearly withdrawals: " + ex.Message);
            }
        }
    }
}