using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace PatientHealth.DataBase
{
    public class AppDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Call the base OnModelCreating method
            base.OnModelCreating(modelBuilder);
        }
    }
}