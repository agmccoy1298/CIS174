using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace TopicFiveWebAppMcCoy.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options, ILogger<StudentContext> logger)
        : base(options) { }

        public DbSet<Student> StudentList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentID = 1,
                    FirstName = "Andrew",
                    LastName = "McCoy",
                    Grade = "D+"
                },
                new Student
                {
                    StudentID = 2,
                    FirstName = "Liam",
                    LastName = "Hemsworth",
                    Grade = "C+"
                },
                new Student
                {
                    StudentID = 3,
                    FirstName = "Daniel",
                    LastName = "Smith",
                    Grade = "A-"
                },
                new Student
                {
                    StudentID = 4,
                    FirstName = "Anna",
                    LastName = "Cox",
                    Grade = "B+"
                });
        }
           
    }
}
