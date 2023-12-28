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
            return _context.TeachList.ToList();
        }

        public Teacher GetTeacherById(int id)
        {
           return _context.TeachList.Find(id);
        }

        public Teacher PostTeacher(Teacher teacher)
        {
            _context.TeachList.Add(teacher);
            _context.SaveChanges();
            return teacher;
        }
        public Teacher PutTeacher(int id,Teacher teach)
        {
            var i = _context.TeachList.Find(id);
            i.Instrument=teach.Instrument;
            i.Name=teach.Name;
            i.Price =teach.Price;
            _context.SaveChanges();
            return i;
        }
        public Teacher DeleteTeacher(int id)
        {
            var i = _context.TeachList.Find(id);
            if (i != null)
                _context.TeachList.Remove(i);
            _context.SaveChanges();
            return i;
        }

    }
}
