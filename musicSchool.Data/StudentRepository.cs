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
            return _context.StuList;
        }
        public Student GetStudentById(int id)
        {
            var i = _context.StuList.Find(e => e.id == id);
            return i;
        }

        public Student PostStudent(Student stu)
        {
            _context.StuList.Add(stu);
            return stu;
        }
        public Student PutStudent(int id,String ins)
        {
            var i = _context.StuList.Find(e => e.id == id);
            var ii = i;
            ii.instrument = ins;
            _context.StuList.Remove(i);
            _context.StuList.Add(ii);
            return ii;
        }
        public Student DeleteStudent(int id)
        {
            var i = _context.StuList.Find(e => e.id == id);
            if (i != null)
                _context.StuList.Remove(i);
            return i;
        }
    }
}
