using Microsoft.AspNetCore.Mvc;
using musicSchool.Core.Entities;
using musicSchool.Data;
using musicShool.Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace musicSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentController : ControllerBase
    {
        private readonly InstrumentService _instrumentService;
        public InstrumentController(InstrumentService instrumentService)
        {
            _instrumentService = instrumentService;
        }
        /*private DataC*//*ontext _context;*/
        //public InstrumentController(DataContext context)
        //{
        //    _context= context;
        //}
        
        // GET: api/<InstrumentController>
        [HttpGet]
        public ActionResult Get()
        { 
            return Ok(_instrumentService.GetAllInstruments());
        }

        // GET api/<InstrumentController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var i = _instrumentService.GetInstrumentById(id);
            if (i != null) 
                return Ok(i);
            return NotFound();
        }

        // POST api/<InstrumentController>
        [HttpPost]
        public ActionResult Post([FromBody] Instrument ins)
        {
            var i =_instrumentService.PostInstrument(ins);
            if(i != null)
              return Ok(ins);
            return NotFound();
        }

        // PUT api/<InstrumentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] int qty)
        {
            var i = _instrumentService.PutInstrument(id, qty);
            if(i != null) 
                return Ok(i);
            return NotFound();
        }


        // DELETE api/<InstrumentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var i = _instrumentService.DeleteInstrument(id);
            if( i != null)
            {
                return Ok(i);
            }
            return NotFound();
        }
    }
}
