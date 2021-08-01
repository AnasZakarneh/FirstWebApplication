using DB.Models;
using DB.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Services
{
    public class ShiftsService : IShiftsService
    {
        private IShiftRepository _shiftsRepository;

        public ShiftsService(IShiftRepository shiftRepository)
        {
            _shiftsRepository = shiftRepository;
        }

        public async Task<Shift> CreateShift(Shift shift)
        {
            return await _shiftsRepository.Create(shift);
        }

        public void DeleteShift(int id)
        {
            _shiftsRepository.Remove(id);
        }

        public IEnumerable<Shift> GetAllShifts()
        {
            return _shiftsRepository.GetAll();
        }

        public Shift GetShiftById(int id)
        {
            return _shiftsRepository.RetrieveShiftDetails(id);
        }

        public void UpdateShift(Shift shift)
        {
            _shiftsRepository.Update(shift);
        }
    }
}
