using Microsoft.AspNetCore.Mvc;
using musicSchool.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace musicSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new List<Student> { new Student { id = 1 ,
            name="defaultName",instrument="defaultInstrument",age = 0} };
        // GET: api/<StudentController>
        [HttpGet]
        public List<Student> Get()
        {
            return students;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var s = students.Find(e => e.id == id);
            if (s != null)
               return Ok(s);
            return NotFound();
        }

        // POST api/<StudentController>
        [HttpPost]
        public Student Post([FromBody] Student stu)
        {
            stu.id++;
            students.Add(stu);
            return stu;
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string ins)
        {
            var s = students.Find(e => e.id == id);
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
            var del=students.Find(e => e.id == id);
            if (del != null) { 
            students.Remove(del);
                return Ok();
            }
            return NotFound();
        }
    }
}
