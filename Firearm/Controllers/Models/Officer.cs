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
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        // Firearm Detail 
        public string FirearmType { get; set; }
        public string FirearmModel { get; set; }
        public string FirearmMechanism { get; set; }
        public string FirearmCalibre { get; set; }
        public string MagazineCapacity { get; set; }
        public string Manufacturer { get; set; }
        public int YearManufacture { get; set; }
        public string Source { get; set; }
        // The body that registered the weapon
        public string RegisteredPosition { get; set; }
        public string RegisteredFullName { get; set; }
        public string RegisteredTitle { get; set; }
        public string RegisteredEmail { get; set; }
        public string RegisteredSignature { get; set; }
        public DateTime RegisteredDate { get; set; }
       

        // The registered body
        public string RegisteredBodyFullName { get; set; }
        public string RegisteredBodyResponsibility { get; set; }
        public string RegisteredBodySignature { get; set; }
        public DateTime RegisteredBodyDate { get; set; }
    }


}

