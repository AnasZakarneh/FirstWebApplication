using DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Services
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetAllEmployees();

        public Employee GetEmployeeById(int id);

        public Task<Employee> CreateEmployee(Employee shift);

        public void UpdateEmployee(Employee shift);

        public void DeleteEmployee(int id);
    }
}
