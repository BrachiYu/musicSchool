using musicSchool.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicShool.Core.Repositories
{
    public interface ITeacherRepository
    {
        List<Teacher>GetAllTeachers();
        Teacher GetTeacherById(int id);
        Teacher PostTeacher(Teacher teacher);
        Teacher PutTeacher(int id, int pri);
        Teacher DeleteTeacher(int id);
    }
}
