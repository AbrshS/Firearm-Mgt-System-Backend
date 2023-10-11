using Firearm.Data;
using Microsoft.AspNetCore.Mvc;

namespace Firearm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecoveryController : Controller
    {


        private readonly FirearmDbContext firearmDbContext;

        public RecoveryController(FirearmDbContext firearmDbContext)
        {
            this.firearmDbContext = firearmDbContext;
        }  

        //Get Recovery 
    }
}
