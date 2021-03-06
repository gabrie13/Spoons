﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EightSpoons.Models;

namespace EightSpoons.Services
{
    interface IEmployeeService
    {
        List<EmployeeViewModel> GetAll();
        EmployeeViewModel FindById(int id);
        EmployeeViewModel Create(EmployeeViewModel employee);
        EmployeeViewModel Save(EmployeeViewModel employee);
        void Delete(int id);
        void Dispose();
    }
}
