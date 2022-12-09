using Lab3.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3.DataBase
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProjectTask> ProjectTasks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectTask>().HasData(
                new ProjectTask
                {
                    Id=1,
                    Name = "Number 1",
                    Description = "New",
                    CreatedDate= DateTime.Now,
                    Priority= 1,
                    Status=Status.New
                },
                 new ProjectTask
                 {
                     Id = 2,
                     Name = "Number 2",
                     Description = "In progress",
                     CreatedDate = DateTime.Now,
                     Priority = 2,
                     Status = Status.InProgress
                 },
                  new ProjectTask
                  {
                      Id = 3,
                      Name = "Number 3",
                      Description = "Closed",
                      CreatedDate = DateTime.Now,
                      Priority = 3,
                      Status = Status.Closed
                  }
            );
        }
    }
}