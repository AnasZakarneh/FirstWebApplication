using Buisness.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace FirstWebApplication.Controllers
{
    [Route("api/v1/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        // GET: api/<EmployeesController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeService.GetAllEmployees()
                .Select(_mapper.Map<Employee>);
        }

        //GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _mapper.Map<Employee>(_employeeService.GetEmployeeById(id));
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public async Task<Employee> Post([FromBody] Employee employee)
        {
            var newEmployee = await _employeeService.CreateEmployee(_mapper.Map<Buisness.Models.Employee>(employee));

            return _mapper.Map<Employee>(newEmployee);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee employee)
        {
            employee.Id = id;
            _employeeService.UpdateEmployee(_mapper.Map<Buisness.Models.Employee>(employee));
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeService.DeleteEmployee(id);
        }
    }
}
