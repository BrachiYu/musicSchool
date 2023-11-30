﻿using Microsoft.AspNetCore.Mvc;
using musicSchool.Core.Entities;
using musicSchool.Data;
using musicShool.Service;
using System.Net;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace musicSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;
        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }
        //private DataContext _context;

       // public StudentController(DataContext context)
        //{
          //  _context = context;
       // }
        // GET: api/<StudentController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_studentService.GetAllStudents());
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var s = _studentService.GetStudentById(id);
            if (s != null)
               return Ok(s);
            return NotFound();
        }

        // POST api/<StudentController>
        [HttpPost]
        public ActionResult Post([FromBody] Student stu)
        {
            var i = _studentService.PostStudent(stu);   
            if (i != null)
                return Ok(stu);
            return NotFound();
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string ins)
        {
            var i = _studentService.PutStudent(id, ins);
            if (i != null)
                return Ok(i);
            return NotFound();
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var del= _studentService.DeleteStudent(id);
            if (del != null) {
                return Ok(del);
            }
            return NotFound();
        }
    }
}
