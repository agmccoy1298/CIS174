using Microsoft.EntityFrameworkCore;

namespace TopicFiveWebAppMcCoy.Models
{
    public class AssignmentContext : DbContext
    {
        public AssignmentContext(DbContextOptions<AssignmentContext> options)
           : base(options)
        { }

        public DbSet<Assignment> Assignments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>().HasData(
                new Assignment
                {
                    AssignmentId = 1,
                    Name = "Unit 3",
                    ClassName = "Advanced C#",                   
                },
                new Assignment
                {
                    AssignmentId = 2,
                    Name = "Testing",
                    ClassName = "CIS Internship",
                },
                new Assignment
                {
                    AssignmentId = 3,
                    Name = "Week 4",
                    ClassName = "Data Science 1",
                }
            );
         
        }
    }
}
