using Microsoft.EntityFrameworkCore;

namespace EmpManagmentSystem.Models
{
    //class representing the db
    public class EmployeeContext : DbContext
    {


        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; } // employee table
        public DbSet<Department> Departments { get; set; } // dept table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { DeptId=1,DeptName="HR"},
                new Department { DeptId=2,DeptName="Finance"},
                new Department { DeptId=3,DeptName="IT"},
                new Department { DeptId=4,DeptName="Marketing"}

                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id=1, DeptId=1, Deptartment=Dept.HR, Name="Sarah", Age=23, ImageName="sarah.png", Address="NJ"},
                new Employee { Id=2, DeptId=1, Deptartment=Dept.HR, Name="Logan", Age=54, ImageName="logan.png", Address="CA"}
                );
        }
    }
}
