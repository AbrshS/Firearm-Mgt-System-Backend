using Firearm.Controllers.Models;
using Firearm.Data;
using Firearm.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly FirearmDbContext firearmDbContext;

        public UserController(FirearmDbContext firearmDbContext)
        {
            this.firearmDbContext = firearmDbContext;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] User userObj)
        {
            if (userObj == null)
                return BadRequest();

            var user = await firearmDbContext.users.FirstOrDefaultAsync(x =>
                x.Username == userObj.Username &&
                x.LoginIcon == userObj.LoginIcon);

            if (user == null)
                return NotFound(new { Message = "User Not Found" });

            // Authenticate the encrypted password 
            if (!PasswordHasher.VerifyPassword(userObj.Password, user.Password))
            {
                return BadRequest(new { Message = "Password is incorrect" });
            }

            user.Token = CreateJwt(user);

            return Ok(new
            {
                Token = user.Token,
                name = user.FirstName,
                Message = "Login Success!"
            });
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] User userObj)
        {
            if (userObj == null)
                return BadRequest();

            // Check username  
            if (await CheckUserNameExistAsync(userObj.Username))
                return BadRequest(new { Message = "Username exist" });

            // Check email 
            if (await CheckEmailExistAsync(userObj.Email))
                return BadRequest(new { Message = "Email exist" });

            // Check password strength 
            var isValid = await CheckPasswordStrength(userObj.Password);
            if (!isValid)
                return BadRequest(new { Message = "Password strength criteria not met." });

            userObj.Password = PasswordHasher.HashPassword(userObj.Password);
            userObj.Token = "";
            await firearmDbContext.users.AddAsync(userObj);
            await firearmDbContext.SaveChangesAsync();
            return Ok(new { Message = "User Registered!" });
        }

        private Task<bool> CheckUserNameExistAsync(string username)
            => firearmDbContext.users.AnyAsync(x => x.Username == username);

        private Task<bool> CheckEmailExistAsync(string email)
            => firearmDbContext.users.AnyAsync(x => x.Email == email);

        // Unified CheckPasswordStrength method
        private async Task<bool> CheckPasswordStrength(string password)
        {
            StringBuilder sb = new StringBuilder();
            if (password.Length < 9)
                sb.Append("Minimum password length should be 8" + Environment.NewLine);
            if (!Regex.IsMatch(password, @"^(?=.*[a-zA-Z0-9])(?=.*[^a-zA-Z0-9]).+$"))
                // Password contains at least one alphanumeric character and special character
                sb.Append("Password should contain one alphanumeric and special character" + Environment.NewLine);

            return sb.Length == 0;
        }

        // Jwt Token
        private string CreateJwt(User user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("veryverysecret.....");

            var identity = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()), // Add NameIdentifier claim
                new Claim("AccountType", user.AccountType),
                new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}")
            });

            var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = identity,
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = credentials,
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            return jwtTokenHandler.WriteToken(token);
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetAllUsers()
        {
            return Ok(await firearmDbContext.users.ToListAsync());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User userObj)
        {
            if (userObj == null || id != userObj.Id)
            {
                return BadRequest(new { Message = "User data is invalid" });
            }

            var user = await firearmDbContext.users.FindAsync(id);
            if (user == null)
            {
                return NotFound(new { Message = "User not found" });
            }

            // Update user properties
            user.FirstName = userObj.FirstName;
            user.MiddleName = userObj.MiddleName;
            user.LastName = userObj.LastName;
            user.EFPID = userObj.EFPID;
            user.Job = userObj.Job;
            user.Unit = userObj.Unit;
            user.Extension = userObj.Extension;
            user.Mobile = userObj.Mobile;
            user.Email = userObj.Email;
            user.AccountType = userObj.AccountType;
            user.LoginIcon = userObj.LoginIcon;
            user.Username = userObj.Username;
 // Ensure the password is hashed

            firearmDbContext.users.Update(user);
            await firearmDbContext.SaveChangesAsync();

            return Ok(new { Message = "User updated successfully!" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await firearmDbContext.users.FindAsync(id);
            if (user == null)
            {
                return NotFound(new { Message = "User not found" });
            }

            firearmDbContext.users.Remove(user);
            await firearmDbContext.SaveChangesAsync();

            return Ok(new { Message = "User deleted successfully!" });
        }

        [HttpGet("profile")]
        public async Task<IActionResult> GetUserProfile()
        {
            var nameId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(nameId))
            {
                return Unauthorized(new { Message = "User identity not found" });
            }

            var user = await firearmDbContext.users.FirstOrDefaultAsync(x => x.Id.ToString() == nameId);
            if (user == null)
            {
                return NotFound(new { Message = "User not found" });
            }

            var userDto = new
            {
                user.Id,
                user.FirstName,
                user.MiddleName,
                user.LastName,
                user.EFPID,
                user.Job,
                user.Unit,
                user.Extension,
                user.Mobile,
                user.Email,
                user.AccountType,
                user.LoginIcon,
                user.Username
            };

            return Ok(userDto);
        }
        [HttpPost("changePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordModel model)
        {
            var nameId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(nameId))
            {
                return Unauthorized(new { Message = "User identity not found" });
            }

            var user = await firearmDbContext.users.FirstOrDefaultAsync(x => x.Id.ToString() == nameId);
            if (user == null)
            {
                return NotFound(new { Message = "User not found" });
            }

            // Verify the current password
            if (!PasswordHasher.VerifyPassword(model.CurrentPassword, user.Password))
            {
                return BadRequest(new { Message = "Current password is incorrect" });
            }

            // Check the new password strength
            var isValid = await CheckPasswordStrength(model.NewPassword);
            if (!isValid)
            {
                return BadRequest(new { Message = "New password strength criteria not met." });
            }

            // Update the password
            user.Password = PasswordHasher.HashPassword(model.NewPassword);
            firearmDbContext.users.Update(user);
            await firearmDbContext.SaveChangesAsync();

            return Ok(new { Message = "Password changed successfully!" });
        }



    }
}
