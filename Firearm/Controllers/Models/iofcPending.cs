using System.ComponentModel.DataAnnotations.Schema;

namespace Firearm.Controllers.Models
{
    public class iofcPending
    {

        [Column("iofcPendingId")]
        public int Id { get; set; }

        public string FullName { get; set; }

        public string CandidateCountry { get; set; }

        public string EvidenceOfMedical { get; set; }

        public string PassportNo { get; set; }

        public string ReasonHeCame { get; set; }
        public DateTime ComingDate { get; set; }
        //adress 
        public string CountryOfResidence { get; set; }
        public string Region { get; set; }
        public string Subcity { get; set; }

        public string District { get; set; }

        public string kebele { get; set; }

        public string SpecificArea { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }


        /// <summary>
        /// firearm detail to be given to the organisation 
        /// </summary>
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

        //the body that register the weapon   
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

        public string holder { get; set; }
    }
}
