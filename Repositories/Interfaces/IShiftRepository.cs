using WorkforceScheduler.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

// IShiftRepository.cs
namespace WorkforceScheduler.Repositories.Interfaces
{
    public interface IShiftRepository
    {
        Task<IEnumerable<Shifts>> GetAllAsync();
        Task AddAsync(Shifts shift);
    }
}
