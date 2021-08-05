using Buisness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Services
{
    public interface IShiftsService
    {
        public IEnumerable<Shift> GetAllShifts();

        public Shift GetShiftById(int id);

        public Task<Shift> CreateShift(Shift shift);

        public void UpdateShift(Shift shift);

        public void DeleteShift(int id);
    }
}
