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
            new Record(4, "Some song", "Some guy", 60, 2000),
            new Record(5, "Your Song", "Elton John", 240, 1970),
            new Record(6, "Unity", "The Fat Rat", 249, 2014),
            new Record(7, "Show Me Your Genitals", "Jon Lajoie", 231, 2008)
        };

        // GET: api/<MusicRecordsController>
        [HttpGet]
        public IEnumerable<Record> Get()
        {
            return Records;
        }

        // GET api/<MusicRecordsController>/5
        [HttpGet]
        [Route("{nr}")]
        public Record GetRecord(int nr)
        {
            return Records.Find(r => r.Nr == nr);
        }

        [HttpGet]
        [Route("Title/{substring}")]
        public IEnumerable<Record> GetFromSubstring(String substring)
        {
            List<Record> lRecord = Records.FindAll(r => r.Title.Contains(substring));
            return lRecord;
        }

        [HttpGet]
        [Route("Artist/{substring}")]
        public IEnumerable<Record> GetFromAnotherSubstring(String substring)
        {
            List<Record> lRecord = Records.FindAll(r => r.Artist.Contains(substring));
            return lRecord;
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
