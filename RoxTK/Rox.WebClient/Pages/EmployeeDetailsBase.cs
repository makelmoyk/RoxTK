using Microsoft.AspNetCore.Components;
using RoxTK.Models;
using RoxTK.Web.Services;
using System.Threading.Tasks;

namespace RoxTK.WebClient.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {

        public Employee Employee { get; set; } = new Employee();
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Parameter]
        public string Id { get; set; }


        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
           
        }
    }
}
