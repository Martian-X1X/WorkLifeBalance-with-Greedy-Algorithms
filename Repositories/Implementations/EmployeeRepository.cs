// EmployeeRepository.cs
using WorkforceScheduler.Data;
using WorkforceScheduler.Models;
using WorkforceScheduler.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace WorkforceScheduler.Repositories.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context) => _context = context;

        public async Task<IEnumerable<Employee>> GetAllAsync() => await _context.Employees.ToListAsync();
        public async Task AddAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }
    }
}