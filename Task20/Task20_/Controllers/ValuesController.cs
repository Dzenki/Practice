using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;


namespace Task20_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public ValuesController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:7151");
        }

        // GET: api/<ValuesController>
        public async Task<IActionResult> Get()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("api/Class");

            if (response.IsSuccessStatusCode)
            {
                var objects = await response.Content.ReadAsAsync<List<Class>>();
                return Ok(objects);
            }

            return Problem("Error getting objects data");
        }
    }
}
