using System.ComponentModel.DataAnnotations.Schema; 

namespace Firearm.Controllers.Models
{
    public class Withdrawal
    {
        [Column("withdrawId")] 

        public int Id { get; set; }

        public string ManufacturerSerial { get; set; }  

        public DateTime WithdrawalDate { get; set; }
    }
    


}