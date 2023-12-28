using musicSchool.Core.Entities;
using musicShool.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicSchool.Data
{
    public class StudentRepository:IStudentRepository
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public List<Student> GetStudents()
        {
            return _context.StuList.ToList();
        }
        public Student GetStudentById(int id)
        {
             return _context.StuList.Find(id);
        }

        public Student PostStudent(Student stu)
        {
            _context.StuList.Add(stu);
            _context.SaveChanges();
            return stu;
        }
        public Student PutStudent(int id,Student stu)
        {
            var i = _context.StuList.Find(id);
            i.Name=stu.Name;
            i.Age=stu.Age;
            i.Instrument = stu.Instrument;
            _context.SaveChanges();
            return i;
        }
        public Student DeleteStudent(int id)
        {
            var i = _context.StuList.Find(id);
            if (i != null)
                _context.StuList.Remove(i);
            _context.SaveChanges();
            return i;
        }
    }
}
