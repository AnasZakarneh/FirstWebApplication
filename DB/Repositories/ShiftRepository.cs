using DB.Data;
using DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DB.Repositories
{
    public class ShiftRepository : Repository<Shift, int>, IShiftRepository
    {
        protected override IQueryable<Shift> RetrieveQuery => _context.Shifts;

        public ShiftRepository(ApplicationDbContext dbContext) : base (dbContext)
        {
        }

        public Shift RetrieveShiftDetails(int id)
        {
            return _context.Shifts.Include(s => s.Employee).FirstOrDefault(s => s.Id == id);
        }
    }
}
