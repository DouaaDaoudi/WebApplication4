using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class HomeController : ControllerBase
    {
        
        [HttpGet(Name = "GetInt")]
        public int Get(int id)
            { 
            return id; 
        }
    }
}
