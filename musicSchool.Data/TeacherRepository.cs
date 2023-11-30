using musicSchool.Core.Entities;
using musicShool.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicSchool.Data
{
    public class TeacherRepository:ITeacherRepository
    {
        private readonly DataContext _context;
        public TeacherRepository(DataContext context)
        {
            _context = context;
        }

        public List<Teacher> GetAllTeachers()
        {
            return _context.TeachList;
        }

        public Teacher GetTeacherById(int id)
        {
            var i = _context.TeachList.Find(e => e.id == id);
            return i;
        }

        public Teacher PostTeacher(Teacher teacher)
        {
            _context.TeachList.Add(teacher);
            return teacher;
        }
        public Teacher PutTeacher(int id, int pri)
        {
            var i = _context.TeachList.Find(e => e.id == id);
            var ii = i;
            ii.price = pri;
            _context.TeachList.Remove(i);
            _context.TeachList.Add(ii);
            return ii;
        }
        public Teacher DeleteTeacher(int id)
        {
            var i = _context.TeachList.Find(e => e.id == id);
            if (i != null)
                _context.TeachList.Remove(i);
            return i;
        }

    }
}
