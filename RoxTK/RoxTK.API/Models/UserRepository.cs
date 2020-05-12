using Microsoft.EntityFrameworkCore;
using RoxTK.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoxTK.API.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly TKDBContext dbContext;

        public UserRepository(TKDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<User> AddUser(User User)
        {
            var result = await dbContext.Users.AddAsync(User);

            await dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteUser(int UserId)
        {
            var result = await dbContext.Users
                .FirstOrDefaultAsync(e => e.UserId == UserId);
            if (result != null)
            {
                dbContext.Users.Remove(result);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<User> GetUser(int UserId)
        {
            return await dbContext.Users
                .FirstOrDefaultAsync(e => e.UserId == UserId);

        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await dbContext.Users.ToListAsync();
        }

        public async Task<User> UpdateUser(User User)
        {
            var result = await dbContext.Users
               .FirstOrDefaultAsync(e => e.UserId == User.UserId);
            if (result != null)
            {
                result.Username = User.Username;
                result.Password = User.Password;


                await dbContext.SaveChangesAsync();

                return result;

            }
            return null;

        }
    }
}
