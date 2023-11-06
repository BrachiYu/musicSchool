using Microsoft.AspNetCore.Mvc;
using musicSchool.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace musicSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private static List<Teacher> teachers = new List<Teacher> { new Teacher { id = 1 , 
            name="defaultName",instrument="defaultInstrument",price = 0} };
        // GET: api/<TeacherController>
        [HttpGet]
        public List<Teacher> Get()
        {
            return teachers;
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var tid = teachers.Find(e => e.id == id);
            if (tid != null)
            {
               return Ok(tid);
            }
            return NotFound();
        }

        // POST api/<TeacherController>
        [HttpPost]
        public Teacher Post([FromBody] Teacher teach)
        {
            teach.id++;
            teachers.Add(teach);
            return teach;
        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] int pri)
        {
            var tid = teachers.Find(e => e.id == id);
            if (tid != null) { 
               tid.price = pri;
                return Ok();
            }
            return NotFound();
        }

        // PUT api/<TeacherController>/5
        //[HttpPut("{id}")]
        //public ActionResult Put(int id, [FromBody] string ins)
        //{
        //    var tid = teachers.Find(e => e.id == id);
        //    if (tid != null)
        //    {
        //        tid.instrument = ins;
        //        return Ok();
        //    }
        //    return NotFound();
        //}

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var tid = teachers.Find(e => e.id == id);
            if(tid != null) { 
              teachers.Remove(tid);
                return Ok();
            }
            return NotFound();
        }
    }
}
