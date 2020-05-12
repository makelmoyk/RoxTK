using RoxTK.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoxTK.API.Models
{
    interface ITimekeepRepository
    {
        Task<IEnumerable<Timekeep>> GetTimekeeps();
        Task<Timekeep> GetTimekeep(int TimeKeepId);
        Task<Timekeep> AddTimekeep(Timekeep timekeep);
        Task<Timekeep> UpdateTimekeep(Timekeep timekeep);
        void DeleteTimekeep(int TimekeepId);
    }
}
