using Microsoft.AspNetCore.Mvc;
using musicSchool.Entities;
using System.Net;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace musicSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentController : ControllerBase
    {
        private static List<Instrument> instruments = new List<Instrument> { new Instrument { id = 1 ,
            name="defaultName",qty=0 ,price = 0} };
        // GET: api/<InstrumentController>
        [HttpGet]
        public List<Instrument> Get()
        {
            return instruments;
        }

        // GET api/<InstrumentController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var i = instruments.Find(e => e.id == id);
            if (i != null) 
                return Ok(i);
            return NotFound();
        }

        // POST api/<InstrumentController>
        [HttpPost]
        public Instrument Post([FromBody] Instrument ins)
        {
            ins.id++;
            instruments.Add(ins);
            return ins;
        }

        // PUT api/<InstrumentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] int qty)
        {
            var i = instruments.Find(e => e.id == id);
            if(i != null) { 
                i.qty = qty;
                return Ok();
            }
            return NotFound();
        }


        // DELETE api/<InstrumentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var i = instruments.Find(e => e.id == id);
            if( i != null)
            {
                instruments.Remove(i);
                return Ok();
            }
            return NotFound();
        }
    }
}
