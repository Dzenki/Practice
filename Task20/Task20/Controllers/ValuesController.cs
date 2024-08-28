using Microsoft.AspNetCore.Mvc;
using Task20.Model;

namespace Task20.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Class> Get()
        {
            return new List<Class>
            {
                new Class { Id = 1, Name = "Item1", Description = "Description1" },
                new Class { Id = 2, Name = "Item2", Description = "Description2" },
                new Class { Id = 3, Name = "Item3", Description = "Description3" }
            };
        }
    }
}
