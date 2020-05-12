using Microsoft.EntityFrameworkCore;
using RoxTK.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoxTK.API.Models
{
    public class TimekeepRepository : ITimekeepRepository
    {
        private readonly TKDBContext dbContext;

        public TimekeepRepository(TKDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Timekeep> AddTimekeep(Timekeep timekeep)
        {
            var result = await dbContext.Timekeeps.AddAsync(timekeep);

            await dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteTimekeep(int TimekeepId)
        {
            var result = await dbContext.Timekeeps
               .FirstOrDefaultAsync(e => e.TimekeepId == TimekeepId);
            if (result != null)
            {
                dbContext.Timekeeps.Remove(result);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<Timekeep> GetTimekeep(int TimeKeepId)
        {
            return await dbContext.Timekeeps
               .FirstOrDefaultAsync(e => e.TimekeepId == TimeKeepId);

        }

        public async Task<IEnumerable<Timekeep>> GetTimekeeps()
        {
            return await dbContext.Timekeeps.ToListAsync();
        }

        public async Task<Timekeep> UpdateTimekeep(Timekeep timekeep)
        {
            var result = await dbContext.Timekeeps
           .FirstOrDefaultAsync(e => e.TimekeepId == timekeep.TimekeepId);
            if (result != null)
            {
                result.LoggedIn = timekeep.LoggedIn;
                result.LoggedOut = timekeep.LoggedOut;

                await dbContext.SaveChangesAsync();

                return result;

            }
            return null;

        }
    }
}
