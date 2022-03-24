using Microsoft.EntityFrameworkCore;
using MyRestApi.Databse.Entities;

namespace MyRestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly PeopleDb db;
        public PeopleController(PeopleDb db){
            this.db = db;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var people = db.People.ToList();
            return Ok(people);
        }
    }
}
