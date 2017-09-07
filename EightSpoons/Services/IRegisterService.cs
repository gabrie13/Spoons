using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EightSpoons.Models;

namespace EightSpoons.Services
{
    interface IRegisterService
    {
        List<RegisterViewModel> GetAll();
        RegisterViewModel FindById(int id);
        RegisterViewModel Create(RegisterViewModel register);
        RegisterViewModel Save(RegisterViewModel register);
        void Delete(int id);
        void Dispose();
    }
}
