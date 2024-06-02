using System.ComponentModel.DataAnnotations.Schema;

namespace Firearm.Controllers.Models
{
    public class Notification
    {
        [Column("NotificationId")]
        public int Id { get; set; }
        public string userFullName { get; set; }
        public string holder { get; set; }
        public bool IsRead { get; set; }  
        public DateTime SentDate { get; set; } 
        public string store {  get; set; } 

    }
}  