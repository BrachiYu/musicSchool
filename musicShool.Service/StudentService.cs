﻿using musicSchool.Core.Entities;
using musicShool.Core.Repositories;
using musicShool.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicShool.Service
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository=studentRepository;
        }
        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetStudents();
        }
        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }
        public Student PostStudent(Student student)
        {
            
            return _studentRepository.PostStudent(student);
        }
        public Student PutStudent(int id, Student stu)
        {
            return _studentRepository.PutStudent(id, stu);
        }
        public Student DeleteStudent(int id)
        {
            return _studentRepository.DeleteStudent(id);
        }
    }
}
