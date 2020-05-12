using RoxTK.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoxTK.Web.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
    }
}
