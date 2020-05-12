using Microsoft.AspNetCore.Components;
using RoxTK.Models;
using RoxTK.Web.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoxTK.WebClient.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public string Search { get; set; }
        public string Caption { get; set; }

        protected async override Task OnInitializedAsync()
        {

            Employees = (await EmployeeService.GetEmployees()).ToList();

        }

        protected async Task SearchEmployee()
        {
            Employees = (await EmployeeService.Search(Search, null));

            if (!Employees.Any())
            {
                Caption = $"There is no such employee combination of \"{Search}\"";
                 
            }
            else
            {

                Caption = $"This is/are the found employee/s from search \"{Search}\"";
                 
            }
        }
    }
}
