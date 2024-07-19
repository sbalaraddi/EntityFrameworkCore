using EFCoreBasics.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace EFCoreBasics.Data
{
    internal class AppDbContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }

        public DbSet<Manager> EmployeeDetails { get; set; }

        public string ConnectionString { get; }

        public AppDbContext()
        {
            //Connection String
            //Data Source = LAPTOP-OURCKOGI\\SQLEXPRESS; Initial Catalog=Demodb;Integrated Security = True;
            ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB; Database=EmployeeMngt_EFCorePractice; Integrated Security = True;";

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure the Primary Key for the Employee
            modelBuilder.Entity<Employee>().HasKey(e => e.EmployeeId);

            //Configure the Required key for the Employee as EmpFirstName
            modelBuilder.Entity<Employee>().Property(e => e.EmployeeId).IsRequired();

            //Many to Many Releation can only be handled with
            modelBuilder.Entity<EmployeeProject>()
                .HasKey(ep => new { ep.EmployeeId, ep.ProjectId });

            modelBuilder.Entity<EmployeeProject>()
                .HasOne(ep => ep.Employee)
                .WithMany(e => e.EmployeeProjects)
                .HasForeignKey(e => e.EmployeeId);

            modelBuilder.Entity<EmployeeProject>()
                .HasOne(ep => ep.Project)
                .WithMany(p => p.EmployeeProjects)
                .HasForeignKey(p => p.ProjectId);
        }
    }
}
