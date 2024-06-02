using System.ComponentModel.DataAnnotations.Schema;

namespace Firearm.Controllers.Models
{
    public class FirearmHolders
    {

        [Column("DestroyedId")]

        public int Id { get; set; }  

        public string holder {  get; set; } 
    }
}
