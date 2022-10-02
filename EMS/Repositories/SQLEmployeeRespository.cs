using DemoDotNetCore.Models;
using EMS.Models;
using EMS.Repositories;
using System.Collections.Generic;

namespace DemoDotNetCore.Repositories
{
    public class SQLEmployeeRespository : IEmployeeRepository
    {
        private readonly AppDatabaseContext context;

        public SQLEmployeeRespository(AppDatabaseContext context)
        {
            this.context = context;
        }
        public Employee CreateEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Employee> getAllEmployees()
        {
            return context.Employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return context.Employees.Find(id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            context.Employees.Update(employee);
            context.SaveChanges();
            return employee;
        }
    }
}
