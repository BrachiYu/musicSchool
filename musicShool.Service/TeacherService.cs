using musicSchool.Core.Entities;
using musicShool.Core.Repositories;
using musicShool.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicShool.Service
{
    public class TeacherService:ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public List<Teacher> GetAllTeachers()
        {
            return _teacherRepository.GetAllTeachers();
        }
        public Teacher GetTeacherById(int id)
        {
            return _teacherRepository.GetTeacherById(id);
        }
        public Teacher PostTeacher(Teacher teach)
        {
            return _teacherRepository.PostTeacher(teach);
        }
        public Teacher PutTeacher(int id, Teacher teach)
        {
            return _teacherRepository.PutTeacher(id, teach);
        }
        public Teacher DeleteTeacher(int id)
        {
            return _teacherRepository.DeleteTeacher(id);
        }
    }
}
