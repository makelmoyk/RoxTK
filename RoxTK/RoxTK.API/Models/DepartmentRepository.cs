using Microsoft.EntityFrameworkCore;
using RoxTK.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoxTK.API.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly TKDBContext dBContext;

        public DepartmentRepository(TKDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async Task<Department> GetDepartment(int departmentId)
        {
            return await dBContext.Departments
                .FirstOrDefaultAsync(e => e.DepartmentId == departmentId);

        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await dBContext.Departments.ToListAsync();
        }
    }
}
