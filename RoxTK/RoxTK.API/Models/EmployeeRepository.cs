using Microsoft.EntityFrameworkCore;
using RoxTK.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoxTK.API.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly TKDBContext dbContext;

        public EmployeeRepository(TKDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await dbContext.Employees.AddAsync(employee);

            await dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> DeleteEmployee(int EmployeeId)
        {
            var result = await dbContext.Employees
                .FirstOrDefaultAsync(e => e.EmployeeId == EmployeeId);
            if (result != null)
            {
                dbContext.Employees.Remove(result);
                await dbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Employee> GetEmployee(int EmployeeId)
        {

            return await dbContext.Employees
                .Include(e => e.Department)
                .FirstOrDefaultAsync(e => e.EmployeeId == EmployeeId);

        }
        public async Task<Employee> GetEmail(string Email)
        {

            return await dbContext.Employees
                .FirstOrDefaultAsync(e => e.Email == Email);

        }



        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await dbContext.Employees
               .FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);
            if (result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Email = employee.Email;
                result.Gender = employee.Gender;
                result.DepartmentId = employee.DepartmentId;
                result.DateOfBirth = employee.DateOfBirth;
                result.ImagePath = employee.ImagePath;

                await dbContext.SaveChangesAsync();

                return result;

            }
            return null;

        }

        public async Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            IQueryable<Employee> query = dbContext.Employees;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.FirstName.Contains(name) || e.LastName.Contains(name));
            }
            if (gender != null)
            {
                query = query.Where(e => e.Gender == gender);
            }




            return await query.ToListAsync();
        }
    }
}
