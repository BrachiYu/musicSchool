namespace musicSchool.Core.Entities
{
    public class MusicList
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public int NumLessons { get; set; }
        public String Level { get; set; }
    }
}