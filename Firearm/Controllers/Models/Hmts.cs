using System.ComponentModel.DataAnnotations.Schema;

namespace Firearm.Controllers.Models
{
    public class Hmts
    {
        [Column("firearmId")]
        public int Id { get; set; } 

        public string CountryOfOrigin { get; set; } 
        public string LicensedCountry { get; set; }

        public string LevelOfService { get; set; }

        public string Subcity { get; set; }

        public string District { get; set; }

        public string kebele { get; set; }

        public string SpecificArea { get; set; } 

        public string PassportNo { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // firearm detail  

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

        public string RegisteredPosition { get; set; }
        public string RegisteredFullName { get; set; }
        public string RegisteredTitle { get; set; }
        public string registeredResponsibility { get; set; }
        public string RegisteredSignature { get; set; }
        public DateTime RegisteredDate { get; set; }


        // The registered body
        public string RegisteredBodyFullName { get; set; }
        public string RegisteredBodyResponsibility { get; set; }
        public string RegisteredBodySignature { get; set; }
        public DateTime RegisteredBodyDate { get; set; }
    }
}
