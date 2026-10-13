using CumpanyMANSYS.Models;
using Microsoft.EntityFrameworkCore;

namespace CumpanyMANSYS.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>()
                .HasMany(d => d.employees)
                .WithOne(e => e.department)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.projects)
                .WithOne(p => p.department)
                .HasForeignKey(p => p.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EmployeeProject>()
                .HasOne(ep => ep.employee)
                .WithMany(k => k.employeeProjects)
                .HasForeignKey(ep => ep.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EmployeeProject>()
                .HasOne(ep => ep.project)
                .WithMany(p => p.employeeProjects)
                .HasForeignKey(ep => ep.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EmployeeProject>()
                .HasIndex(ep => new { ep.EmployeeId, ep.ProjectId })
                .IsUnique();

            modelBuilder.Entity<Department>()
                .HasData(
                    new Department { Id = 1, Name = "IT", Location = "New York" },
                    new Department { Id = 2, Name = "HR", Location = "Los Angeles" },
                    new Department { Id = 3, Name = "Finance", Location = "Chicago" }
                );

            
           
        }
    }
}
