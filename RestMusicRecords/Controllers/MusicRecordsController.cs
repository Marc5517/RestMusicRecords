using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestMusicRecords.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestMusicRecords.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase
    {
        private static readonly List<Record> Records = new List<Record>()
        {
            new Record(1, "I'm still standing", "Elton John", 182, 1983),
            new Record(2, "Timelapse", "The Fat Rat", 120, 2015),
            new Record(3, "We are", "Hiroshi Kitadani", 240, 1999),
            new Record(4, "Some song", "Some guy", 60, 2000)
        };

        // GET: api/<MusicRecordsController>
        [HttpGet]
        public IEnumerable<Record> Get()
        {
            return Records;
        }

        // GET api/<MusicRecordsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MusicRecordsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MusicRecordsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MusicRecordsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
