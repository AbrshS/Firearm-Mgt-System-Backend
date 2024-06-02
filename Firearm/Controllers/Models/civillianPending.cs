using System.ComponentModel.DataAnnotations.Schema;

namespace Firearm.Controllers.Models
{
    public class civillianPending
    {

        [Column("CivillianPendingId")]

        public int Id { get; set; }

        public string Fullname { get; set; }

        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }

        public string AcadamicStatus { get; set; }

        public string MartialStatus { get; set; }

        public string MedicalStatus { get; set; }
        public string Occupation { get; set; }

        public string SizeOfCapital { get; set; }
        public string State { get; set; }
        public string Subcity { get; set; }

        public string District { get; set; }

        public string Kebele { get; set; }

        public string SpecificArea { get; set; }

        public string PassportId { get; set; }

        public string phonenumber { get; set; }

        public string homenumber { get; set; }

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
        public string holder { get; set; }

        // The body that registered the weapon
        public string RegisteredPosition { get; set; }
        public string RegisteredFullName { get; set; }
        public string RegisteredTitle { get; set; }
        public string RegisteredSignature { get; set; }
        public DateTime RegisteredDate { get; set; }

        // The registered body
        public string RegisteredBodyFullName { get; set; }
        public string RegisteredBodyResponsibility { get; set; }
        public string RegisteredBodySignature { get; set; }
        public DateTime RegisteredBodyDate { get; set; }
    }
}
