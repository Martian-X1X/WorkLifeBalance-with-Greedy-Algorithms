using WorkforceScheduler.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

// IEmployeeRepository.cs
namespace WorkforceScheduler.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task AddAsync(Employee employee);
    }
}
