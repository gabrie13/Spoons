using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EightSpoons.Models;

namespace EightSpoons.Services
{
    public class EmployeeService : IEmployeeService
    {
        private EightSpoonsDB db = new EightSpoonsDB();

        public List<EmployeeViewModel> GetAll()
        {
            var employeeList = db.Employees.ToList();
            return employeeList.Select(emp => EmpDto(emp)).ToList();
        }

        private static EmployeeViewModel EmpDto(Employee emp)
        {
            return new EmployeeViewModel
            {
                EmployeeId = emp.EmployeeId,
                FirstName  = emp.FirstName,
                LastName   = emp.LastName,
                Address    = emp.Address,
                City       = emp.City,
                State      = emp.State,
                ZipCode    = emp.ZipCode,
                Email      = emp.Email,
                Phone      = emp.Phone
            };
        }

        public EmployeeViewModel FindById(int id)
        {
            var employee = db.Employees.Find(id);
            return employee != null ? EmpDto(employee) : null;
        }

        public EmployeeViewModel Create(EmployeeViewModel employee)
        {
            var emp = fromEmp(employee);
            db.Employees.Add(emp);
            db.SaveChanges();

            employee.EmployeeId = emp.EmployeeId;
            return EmpDto(emp);
        }

        private static Employee fromEmp(EmployeeViewModel employee)
        {
            var emp = new Employee
            {
                EmployeeId = employee.EmployeeId,
                FirstName  = employee.FirstName,
                LastName   = employee.LastName,
                Address    = employee.Address,
                City       = employee.City,
                State      = employee.State,
                ZipCode    = employee.ZipCode,
                Phone      = employee.Phone,
                Email      = employee.Email
            };
            return emp;
        }

        public EmployeeViewModel Save(EmployeeViewModel employee)
        {
            var emp = fromEmp(employee);
            db.Entry(emp).State = EntityState.Modified;
            db.SaveChanges();

            return EmpDto(emp);
        }

        public void Delete(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       