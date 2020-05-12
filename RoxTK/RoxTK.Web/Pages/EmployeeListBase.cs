using Microsoft.AspNetCore.Components;
using RoxTK.Models;
using RoxTK.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoxTK.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public Employee Employee { get; set; }

        protected async override Task OnInitializedAsync()
        {
            //LoadEmployees();
            //return base.OnInitializedAsync();
            Employee = (await EmployeeService.GetEmployee(1));
        }


        //public void LoadEmployees()
        //{
        //    Employee e1 = new Employee
        //    {
        //        EmployeeId = 1,
        //        FirstName = "Michael",
        //        LastName = "Agana"
        //    };
        //    Employee e2 = new Employee
        //    {
        //        EmployeeId = 1,
        //        FirstName = "Michaels",
        //        LastName = "Agana"
        //    };

        //    Employees = new List<Employee> { e1,e2};


        //}
    }
}
