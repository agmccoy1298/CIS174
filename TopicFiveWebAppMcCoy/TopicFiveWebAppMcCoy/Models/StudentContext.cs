using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace TopicFiveWebAppMcCoy.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options, ILogger<StudentContext> logger)
        : base(options) { }

        public DbSet<Student> Assignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    FirstName = "Andrew",
                    LastName = "McCoy",
                    Grade = "D+"
                },
                new Student
                {
                    FirstName = "Liam",
                    LastName = "Hemsworth",
                    Grade = "C+"
                },
                new Student
                {
                    FirstName = "Daniel",
                    LastName = "Smith",
                    Grade = "A-"
                },
                new Student
                {
                    FirstName = "Anna",
                    LastName = "Cox",
                    Grade = "B+"
                });
        }
           
    }
}
