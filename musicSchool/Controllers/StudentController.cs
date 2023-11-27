using Microsoft.AspNetCore.Mvc;
using musicSchool.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace musicSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private DataContext _context;

        public StudentController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public List<Student> Get()
        {
            return _context.StuList;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var s = _context.StuList.Find(e => e.id == id);
            if (s != null)
               return Ok(s);
            return NotFound();
        }

        // POST api/<StudentController>
        [HttpPost]
        public Student Post([FromBody] Student stu)
        {
            stu.id++;
            _context.StuList.Add(stu);
            return stu;
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string ins)
        {
            var s = _context.StuList.Find(e => e.id == id);
            if(s != null) { 
            s.instrument = ins;
                return Ok();
            }
            return NotFound();
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var del= _context.StuList.Find(e => e.id == id);
            if (del != null) {
                _context.StuList.Remove(del);
                return Ok();
            }
            return NotFound();
        }
    }
}
