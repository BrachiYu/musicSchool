using musicSchool.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicShool.Core.Repositories
{
    public interface IStudentRepository
    {
        List<Student>GetStudents();
        Student GetStudentById(int id);
        Student PostStudent(Student student);
        Student PutStudent(int id, Student stu);
        Student DeleteStudent(int id);
    }
}
