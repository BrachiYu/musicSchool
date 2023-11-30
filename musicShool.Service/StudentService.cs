using musicSchool.Core.Entities;
using musicShool.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicShool.Service
{
    public class StudentService
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
            student.id++;
            return _studentRepository.PostStudent(student);
        }
        public Student PutStudent(int id, String ins)
        {
            return _studentRepository.PutStudent(id, ins);
        }
        public Student DeleteStudent(int id)
        {
            return _studentRepository.DeleteStudent(id);
        }
    }
}
