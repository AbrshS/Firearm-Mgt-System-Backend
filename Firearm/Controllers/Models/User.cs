
using System.ComponentModel.DataAnnotations.Schema;

namespace Firearm.Controllers.Models
{
 
    public class User
    {
        [Column("userId")]
        public int Id { get; set; }
        public int nameid { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int EFPID { get; set; }
        public string Job { get; set; }
        public string Unit { get; set; }
        public int Extension { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public string AccountType { get; set; }
        public string LoginIcon { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }

    }
}     