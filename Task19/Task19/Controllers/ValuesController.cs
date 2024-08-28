using Microsoft.AspNetCore.Mvc;
using Task19.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task19.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] string param) 
        {
            Class class1 = new Class();
            return Ok(class1.Method(param));
        }
    }
}
