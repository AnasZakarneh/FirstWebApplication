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
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository shiftRepository)
        {
            _employeeRepository = shiftRepository;
        }

        public async Task<Employee> CreateEmployee(Employee shift)
        {
            return await _employeeRepository.Create(shift);
        }

        public void DeleteEmployee(int id)
        {
            _employeeRepository.Remove(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.FindById(id);
        }

        public void UpdateEmployee(Employee shift)
        {
            _employeeRepository.Update(shift);
        }
    }
}
