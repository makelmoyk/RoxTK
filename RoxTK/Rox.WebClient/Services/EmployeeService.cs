using Microsoft.AspNetCore.Components;
using RoxTK.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;



namespace RoxTK.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpclient;

        public EmployeeService(HttpClient httpclient)
        {
            this.httpclient = httpclient;
        }

        public async Task<Employee> GetEmployee(int id)
        {

            return await httpclient.GetJsonAsync<Employee>($"api/employees/{id}");
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpclient.GetJsonAsync<Employee[]>("api/employees");

        }

        public async Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            var result = httpclient.GetJsonAsync<Employee[]>($"api/employees/seach?name={name}&gender={gender}");

            return await result;

        }
    }
}
