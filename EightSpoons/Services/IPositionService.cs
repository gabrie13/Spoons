﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EightSpoons.Models;
using System.Data.Entity;

namespace EightSpoons.Services
{
    interface IPositionService
    {
        List<PositionViewModel> GetAll();
        PositionViewModel FindById(int id);
        PositionViewModel Create(PositionViewModel position);
        PositionViewModel Save(PositionViewModel position);
        void Delete(int id);
        void Dispose();

    }
}
