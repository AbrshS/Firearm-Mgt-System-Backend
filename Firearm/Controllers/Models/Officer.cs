using System.ComponentModel.DataAnnotations.Schema;


namespace Firearm.Controllers.Models
{
    public class Officer
    {
        [Column("OfficerId")]

        public int Id { get; set; } 

        public string FullName { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public string Description { get; set; }


        public DateOnly Date {  get; set; }


    }
}
