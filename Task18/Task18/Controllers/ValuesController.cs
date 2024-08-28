using Microsoft.AspNetCore.Mvc;


namespace Task18.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/
        [HttpGet]
        public IActionResult GetData([FromQuery] string query)
        {
            return Ok($"GET request. Query : {query}");
        }

        // GET api/id
        //[HttpGet("{id}")]

        // POST api/
        [HttpPost]
        public IActionResult PostData([FromBody] string body)
        {
            return Ok($"POST request. Body : {body}");
        }

        // PUT api/id
        [HttpPut]
        [Route("{id}")]
        public IActionResult PutData([FromRoute] int id, [FromBody] string body)
        {
            return Ok($"POST request. Body : {body}");
        }

        // DELETE api/id
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteData([FromRoute] int id)
        {
            return Ok($"DELETE request. ID: {id}");
        }
    }
}
