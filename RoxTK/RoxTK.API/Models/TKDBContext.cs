using Microsoft.EntityFrameworkCore;
using RoxTK.Models;
using System;

namespace RoxTK.API.Models
{
    public class TKDBContext : DbContext
    {
        public TKDBContext(DbContextOptions<TKDBContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Timekeep> Timekeeps { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Department Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "FC" });
            modelBuilder.Entity<Department>().HasData(
             new Department { DepartmentId = 3, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
             new Department { DepartmentId = 4, DepartmentName = "Marketing" });


            modelBuilder.Entity<Employee>().HasData(
             new Employee
             {
                 EmployeeId = 1,
                 FirstName = "Michael Angelo",
                 LastName = "Agana",
                 Email = "magana@servio.ph",
                 DateOfBirth = new DateTime(1998, 11, 20),
                 Gender = Gender.Male,
                 DepartmentId = 1,
                 ImagePath = "Images/Michael.jpeg"
             });
            modelBuilder.Entity<Employee>().HasData(
           new Employee
           {
               EmployeeId = 2,
               FirstName = "Dale",
               LastName = "Aguil",
               Email = "daguil@servio.ph",
               DateOfBirth = new DateTime(1997, 03, 12),
               Gender = Gender.Male,
               DepartmentId = 1,
               //Timekeep = new Timekeep { TimekeepId = 2, DateCreated = DateTime.Now, LoggedIn = new DateTime(2020, 4, 21, 10, 0, 0), LoggedOut = new DateTime(2020, 4, 21, 19, 0, 0) },
               ImagePath = "Images/Dale.jpeg"
           });
            modelBuilder.Entity<Employee>().HasData(
           new Employee
           {
               EmployeeId = 3,
               FirstName = "Maynard",
               LastName = "Boliver",
               Email = "mboliver@servio.ph",
               DateOfBirth = new DateTime(1999, 3, 31),
               Gender = Gender.Male,
               DepartmentId = 3,
               //Timekeep = new Timekeep { TimekeepId = 3, DateCreated = DateTime.Now, LoggedIn = new DateTime(2020, 4, 21, 7, 0, 0), LoggedOut = new DateTime(2020, 4, 21, 15, 0, 0) },
               ImagePath = "Images/Maynard.jpeg"
           });
            modelBuilder.Entity<Employee>().HasData(
           new Employee
           {
               EmployeeId = 4,
               FirstName = "Caye Alexis",
               LastName = "Distajo",
               Email = "cdistajo@servio.ph",
               DateOfBirth = new DateTime(1998, 11, 05),
               Gender = Gender.Female,
               DepartmentId = 2,
               //Timekeep = new Timekeep { TimekeepId = 4, DateCreated = DateTime.Now, LoggedIn = new DateTime(2020, 4, 21, 7, 30, 0), LoggedOut = new DateTime(2020, 4, 21, 16, 0, 0) },
               ImagePath = "Images/Caye.jpeg"
           });
            modelBuilder.Entity<Employee>().HasData(
           new Employee
           {
               EmployeeId = 5,
               FirstName = "Mary Rose",
               LastName = "Alcazaren",
               Email = "malcazaren@servio.ph",
               DateOfBirth = new DateTime(1998, 10, 18),
               Gender = Gender.Female,
               DepartmentId = 4,
               //Timekeep = new Timekeep { TimekeepId = 5, DateCreated = DateTime.Now, LoggedIn = new DateTime(2020, 4, 21, 8, 30, 0), LoggedOut = new DateTime(2020, 4, 21, 16, 30, 0) },
               ImagePath = "Images/Rose.jpeg"
           });

            modelBuilder.Entity<User>().HasData(
             new User
             {
                 UserId = 1,
                 Username = "Admin",
                 Password = "Password1",
                 Role = Role.Admin
             });

            modelBuilder.Entity<Timekeep>().HasData(
            new Timekeep
            {
                EmployeeId = 1,
                TimekeepId = 1,
                LoggedIn = new DateTime(2020, 11, 20, 8, 20, 0, 0),
                LoggedOut = new DateTime(2020, 11, 20, 16, 20, 0, 0)
            });

        }
    }
}
