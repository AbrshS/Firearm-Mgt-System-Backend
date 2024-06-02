using System.ComponentModel.DataAnnotations.Schema;

namespace Firearm.Controllers.Models
{
    public class Destroyed
    {
        [Column("DestroyedId")]

        public int Id { get; set; }

        // Detail of Destruction 
        public DateTime DestructionDate { get; set; }

        public string DestructionRequestedBy { get; set; }

        public string ReasonForDestruction { get; set; }

        public string AuthorizedBy { get; set; }

        public string ManufacturerSerial { get; set; }

        public bool IsFirearm { get; set; }

        public DateTime DateMarked { get; set; }

        public string MarkedBy { get; set; }

        public string FirearmType { get; set; }

        public string FirearmModel { get; set; }

        public string FirearmMechanism { get; set; }

        public string FirearmCalibre { get; set; }

        public string MagazineCapacity { get; set; }

        public string Manufacturer { get; set; }

        public DateTime YearManufacture { get; set; }

        public string Source { get; set; }

        public string Store { get; set; }

        public string AdditionalComment { get; set; }

        public DateTime AuthorizationDate { get; set; }
        public DateTime DateDestroyed { get; internal set; }

        public string holder { get; set; }

    }
}