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
        private IRepository<Shift> _shiftsRepository;

        public ShiftsService(IRepository<Shift> shiftRepository)
        {
            _shiftsRepository = shiftRepository;
        }

        public async Task<Shift> CreateShift(Shift shift)
        {
            return await _shiftsRepository.Create(shift);
        }

        public void DeleteShift(int id)
        {
            _shiftsRepository.Delete(id);
        }

        public IEnumerable<Shift> GetAllShifts()
        {
            return _shiftsRepository.GetAll();
        }

        public Shift GetShiftById(int id)
        {
            return _shiftsRepository.GetById(id);
        }

        public void UpdateShift(Shift shift)
        {
            _shiftsRepository.Update(shift);
        }
    }
}
