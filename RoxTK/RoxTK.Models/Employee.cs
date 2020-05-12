using System;
using System.ComponentModel.DataAnnotations;

namespace RoxTK.Models
{
    public class Employee
    {
        
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "You need to provide a First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "You need to provide a Last Name")]
        public string LastName { get; set; }
        [Required()]
        [EmailAddress()]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public Timekeep Timekeep { get; set; }
        public string ImagePath { get; set; }

    }
}
