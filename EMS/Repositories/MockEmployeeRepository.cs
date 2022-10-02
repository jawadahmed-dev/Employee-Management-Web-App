using EMS.Models;
using System.Collections.Generic;
using System.Linq;

namespace EMS.Repositories
{
    public class MockEmployeeRepository : IEmployeeRepository
    {

        List<Employee> employeeList = new List<Employee>();

        public MockEmployeeRepository()
        {
            employeeList.Add(new Employee
            {
                Name = "John Doe",
                Email = "johndoe@gmail.com",
                Id = 1011,
                Department = Department.HR
            });

            employeeList.Add(new Employee
            {
                Name = "ron liam",
                Email = "ronliam@gmail.com",
                Id = 1032,
                Department = Department.IT
            });

        }

        public Employee CreateEmployee(Employee employee)
        {
            employee.Id = employeeList.Max(e => e.Id) + 1;
            employeeList.Add(employee);
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee = employeeList.Find(e => e.Id == id);
            if (employee != null) {
                employeeList.Remove(employee);    
            }
            return employee;
        }

        public IEnumerable<Employee> getAllEmployees()
        {
            return employeeList;    
        }

        public Employee GetEmployeeById(int id)
        {

            return employeeList.Where(x => x.Id == id).FirstOrDefault();
        }

        public Employee UpdateEmployee(Employee employeeChanges)
        {

            Employee employee = employeeList.Find(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Id = employeeChanges.Id;
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
