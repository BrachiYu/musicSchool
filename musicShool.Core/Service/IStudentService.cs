using musicSchool.Core.Entities;
using musicShool.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicShool.Core.Service
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        Student PostStudent(Student student);
        Student PutStudent(int id, Student stu);
        Student DeleteStudent(int id);
    }
}
