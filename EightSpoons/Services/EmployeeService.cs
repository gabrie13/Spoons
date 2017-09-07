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
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       