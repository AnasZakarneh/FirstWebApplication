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
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        private IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository,
            IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            var createdEmployee =  await _employeeRepository.Create(_mapper.Map<DB.Models.Employee>(employee));

            return _mapper.Map<Employee>(createdEmployee);
        }

        public void DeleteEmployee(int id)
        {
            _employeeRepository.Remove(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll()
                .Select(_mapper.Map<Employee>);
        }

        public Employee GetEmployeeById(int id)
        {
            return _mapper.Map<Employee>(_employeeRepository.FindById(id));
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.Update(_mapper.Map<DB.Models.Employee>(employee));
        }
    }
}
