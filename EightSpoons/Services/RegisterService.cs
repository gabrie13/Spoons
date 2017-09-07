using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EightSpoons.Models;

namespace EightSpoons.Services
{
    public class RegisterService : IRegisterService
    {
        private EightSpoonsDB db = new EightSpoonsDB();

        public List<RegisterViewModel> GetAll()
        {
            var registerList = db.Registers.ToList();
            return registerList.Select(reg => RegDto(reg)).ToList();
        }

        private static RegisterViewModel RegDto(Register reg)
        {
            return new RegisterViewModel
            {
                RegisterId = reg.RegisterId,
                Cash       = reg.Cash,
                Check      = reg.Check,
                Visa       = reg.Visa,
                MasterCard = reg.MasterCard,
                Discover   = reg.Discover,
                Amex       = reg.Amex,
                GiftCard   = reg.GiftCard,
                Tax        = reg.Tax,
                CcTotal    = reg.Visa + reg.MasterCard + reg.Discover + reg.Amex,
                Total      = reg.Cash + reg.Check + reg.Visa + reg.MasterCard + reg.Discover + reg.Amex + reg.GiftCard + reg.Tax
            };
        }

        public RegisterViewModel FindById(int id)
        {
            var register = db.Registers.Find(id);
            return register != null ? RegDto(register) : null;
        }

        public RegisterViewModel Create(RegisterViewModel register)
        {
            var reg = fromReg(register);
            db.Registers.Add(reg);
            db.SaveChanges();

            register.RegisterId = reg.RegisterId;
            return RegDto(reg);
        }

        private static Register fromReg(RegisterViewModel register)
        {
            var reg = new Register
            {
                RegisterId = register.RegisterId,
                Cash       = register.Cash,
                Check      = register.Check,
                Visa       = register.Visa,
                MasterCard = register.MasterCard,
                Discover   = register.Discover,
                Amex       = register.Amex,
                GiftCard   = register.GiftCard,
                Tax        = register.Tax
            };
            return reg;
        }

        public RegisterViewModel Save(RegisterViewModel register)
        {
            var reg = fromReg(register);
            db.Entry(reg).State = EntityState.Modified;
            db.SaveChanges();

            return RegDto(reg);
        }

        public void Delete(int id)
        {
            Register register = db.Registers.Find(id);
            db.Registers.Remove(register);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}