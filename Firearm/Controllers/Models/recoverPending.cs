using System.ComponentModel.DataAnnotations.Schema;

namespace Firearm.Controllers.Models
{
    public class recoverPending
    {
        //Recovery condition details:- this details are when the firearm is recoverd from lost 
        [Column("recoverPendingId")]
        public int Id { get; set; }

        public string FirearmReturnedTo { get; set; }

        public string ReportedBy { get; set; }

        public string AuthorizedBy { get; set; }
        public DateTime AuthorizedDate { get; set; }

        //this attributes are for Return Conditon 

        public string ReasonToReturn { get; set; }
        public string Status { get; set; }

        //firearm to returned 
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
    }
}
