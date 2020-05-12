using RoxTK.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoxTK.API.Models
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int UserId);
        Task<User> AddUser(User user);
        Task<User> UpdateUser(User user);
        void DeleteUser(int UserId);

    }
}
