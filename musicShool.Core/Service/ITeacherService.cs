using musicSchool.Core.Entities;
using musicShool.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicShool.Core.Service
{
    public interface ITeacherService
    {
        List<Teacher> GetAllTeachers();
        Teacher GetTeacherById(int id);
        Teacher PostTeacher(Teacher teach);
        Teacher PutTeacher(int id, Teacher teach);
        Teacher DeleteTeacher(int id);
    }
}
