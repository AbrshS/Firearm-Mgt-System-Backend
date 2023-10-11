using System.ComponentModel.DataAnnotations.Schema;

namespace Firearm.Controllers.Models
{
    public class Loss
    {
        [Column("LossId")]

        public int Id { get; set; } 
        public string FullName { get; set; } 
        public string FpId { get; set; }
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
        public string Lholder { get; set; }
        public string AdditionalComment { get; set; }
        public DateTime ReportedOn {get; set; } 
        public string Comment { get; set; }
    }
}
