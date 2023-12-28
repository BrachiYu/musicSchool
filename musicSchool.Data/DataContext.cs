using Microsoft.EntityFrameworkCore;
using musicSchool.Core.Entities;

namespace musicSchool.Data;

public class DataContext:DbContext
{
    public DbSet<MusicList> MusList { get; set; }
    public DbSet<Student> StuList { get; set; }
    public DbSet<Teacher> TeachList { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=brachi1_sample_db");
    }


}
