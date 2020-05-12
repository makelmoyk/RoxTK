using Microsoft.AspNetCore.Components;
using System;
using RoxTK.Models;
using RoxTK.Web.Services;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace RoxTK.WebClient.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        public Employee Employee { get; set; } = new Employee();
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        [Parameter]
        public string Id { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();

        protected async override Task OnInitializedAsync()
        {
            Departments = (await DepartmentService.GetDepartments()).ToList();
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }
    }
}
