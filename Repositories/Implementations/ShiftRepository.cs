using WorkforceScheduler.Data;
using WorkforceScheduler.Models;
using WorkforceScheduler.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;  // Add for IEnumerable

namespace WorkforceScheduler.Repositories.Implementations
{
    public class ShiftRepository : IShiftRepository
    {
        private readonly AppDbContext _context;
        public ShiftRepository(AppDbContext context) => _context = context;

        public async Task<IEnumerable<Shifts>> GetAllAsync() => await _context.Shifts.ToListAsync();  // Line 9: Changed to IEnumerable<Shifts>
        public async Task AddAsync(Shifts shift)
        {
            await _context.Shifts.AddAsync(shift);
            await _context.SaveChangesAsync();
        }
    }
}