using DB.Data;
using DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Repositories
{
    public class ShiftsRepository : IRepository<Shift>
    {
        ApplicationDbContext _context;

        public ShiftsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Shift> Create(Shift shift)
        {
            var shiftEntry = await _context.Shifts.AddAsync(shift);
            _context.SaveChanges();

            return shiftEntry.Entity;
        }

        public IEnumerable<Shift> GetAll()
        {
            return _context.Shifts.ToList();
        }

        public Shift GetById(int id)
        {
            return _context.Shifts.FirstOrDefault(shift => shift.Id == id);
        }

        public void Update(Shift shift)
        {
            _context.Shifts.Update(shift);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shift = GetById(id);

            _context.Shifts.Remove(shift);
            _context.SaveChanges();
        }
    }
}
