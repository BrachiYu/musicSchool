using musicSchool.Entities;

namespace musicSchool
{
    public class DataContext
    {
        public List<Instrument> InsList { get; set; }
        public List<Student> StuList { get; set; }
        public List<Teacher> TeachList { get; set; }

        public DataContext()
        {
            InsList = new List<Instrument>();
            InsList.Add(new Instrument{ id = 1 ,
            name="defaultName",qty = 0 ,price = 0} );
            StuList = new List<Student>();
            StuList.Add(new Student
            {
                id = 1,
                name = "defaultName",
                instrument = "defaultInstrument",
                age = 0
            });
            TeachList = new List<Teacher>();
            TeachList.Add(new Teacher
            {
                id = 1,
                name = "defaultName",
                instrument = "defaultInstrument",
                price = 0
            });
    }
    }
}
