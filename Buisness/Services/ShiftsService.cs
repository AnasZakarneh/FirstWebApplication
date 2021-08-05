using AutoMapper;
using Buisness.Models;
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
        private IMapper _mapper;

        public ShiftsService(IShiftRepository shiftRepository, IMapper mapper)
        {
            _shiftsRepository = shiftRepository;
            _mapper = mapper;
        }

        public async Task<Shift> CreateShift(Shift shift)
        {
            var createdShift =  await _shiftsRepository.Create(_mapper.Map<DB.Models.Shift>(shift));

            return _mapper.Map<Shift>(createdShift);
        }

        public void DeleteShift(int id)
        {
            _shiftsRepository.Remove(id);
        }

        public IEnumerable<Shift> GetAllShifts()
        {
            return _shiftsRepository.GetAll()
                .Select(_mapper.Map<Shift>);
        }

        public Shift GetShiftById(int id)
        {
            return _mapper.Map<Shift>(_shiftsRepository.RetrieveShiftDetails(id));
        }

        public void UpdateShift(Shift shift)
        {
            _shiftsRepository.Update(_mapper.Map<DB.Models.Shift>(shift));
        }
    }
}
