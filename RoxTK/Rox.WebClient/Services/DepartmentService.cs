using Microsoft.AspNetCore.Components;
using RoxTK.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;



namespace RoxTK.Web.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient httpclient;

        public DepartmentService(HttpClient httpclient)
        {
            this.httpclient = httpclient;
        }

        public async Task<Department> GetDepartment(int id)
        {

            return await httpclient.GetJsonAsync<Department>($"api/Departments/{id}");
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await httpclient.GetJsonAsync<Department[]>("api/Departments");

        }
    }
}