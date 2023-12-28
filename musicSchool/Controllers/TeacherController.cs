using Microsoft.AspNetCore.Mvc;
using musicSchool.Data;
using musicSchool.Core.Entities;
using musicShool.Service;
using System.Net;
using musicShool.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace musicSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
       


        // GET: api/<TeacherController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_teacherService.GetAllTeachers());
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var tid = _teacherService.GetTeacherById(id);
            if (tid is not null)
            {
               return Ok(tid);
            }
            return NotFound();
        }

        // POST api/<TeacherController>
        [HttpPost]
        public ActionResult Post([FromBody] Teacher teach)
        {
            var t=_teacherService.PostTeacher(teach);
            if (t is not null)
                return Ok(teach);
            return NotFound();
        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Teacher teach)
        {
            var tid = _teacherService.PutTeacher(id, teach);
            if (tid is not null) { 
                return Ok(tid);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var tid = _teacherService.DeleteTeacher(id);
            if(tid is null) {
                return NotFound();  
            }
            return NoContent();
        }
    }
}
