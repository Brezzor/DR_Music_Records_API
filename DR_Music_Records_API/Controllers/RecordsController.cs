using DR_Music_Records_API.Models;
using DR_Music_Records_API.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DR_Music_Records_API.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private readonly RecordRepository? _recordRepository;

        public RecordsController(RecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }

        // GET: api/<RecordsController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet]
        public ActionResult<IEnumerable<Record>> GetAll(
            [FromQuery] string? title, 
            [FromQuery] string? artist, 
            [FromQuery] int? duration, 
            [FromQuery] int? publicationyear)
        {
            List<Record>? records = _recordRepository!.GetAll(title, artist, duration, publicationyear);
            if (records == null || records.Count < 1)
            {
                return NoContent();
            }
            return Ok(records);
        }

        // GET api/<RecordsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RecordsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RecordsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RecordsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
