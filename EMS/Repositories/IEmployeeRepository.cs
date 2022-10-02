using EMS.Models;
using System.Collections.Generic;

namespace EMS.Repositories
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> getAllEmployees();
        Employee GetEmployeeById(int id);
        Employee CreateEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        Employee DeleteEmployee(int id);
    }
}
