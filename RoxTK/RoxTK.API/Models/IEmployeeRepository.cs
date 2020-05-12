using RoxTK.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoxTK.API.Models
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int EmployeeId);
        Task<Employee> GetEmail(string Email);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int EmployeeId);

    }
}
