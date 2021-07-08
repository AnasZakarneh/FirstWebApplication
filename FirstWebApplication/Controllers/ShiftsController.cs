using Buisness.Services;
using DB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication.Controllers
{
    [Route("api/v1/shifts")]
    [ApiController]
    public class ShiftsController : ControllerBase
    {
        private readonly IShiftsService _shiftService;
        public ShiftsController(IShiftsService shiftsService)
        {
            _shiftService = shiftsService;
        }

        // GET: api/<ShiftsController>
        [HttpGet]
        public IEnumerable<Shift> Get()
        {
            return _shiftService.GetAllShifts();
        }

        //GET api/<ShiftsController>/5
        [HttpGet("{id}")]
        public Shift Get(int id)
        {
            return _shiftService.GetShiftById(id);
        }

        // POST api/<ShiftsController>
        [HttpPost]
        public async Task<Shift> Post([FromBody] Shift shift)
        {
            var newShift = await _shiftService.CreateShift(shift);

            return newShift;
        }

        // PUT api/<ShiftsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Shift shift)
        {
            shift.Id = id;
            _shiftService.UpdateShift(shift);
        }

        // DELETE api/<ShiftsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _shiftService.DeleteShift(id);
        }
    }
}
