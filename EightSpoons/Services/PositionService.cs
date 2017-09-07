using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EightSpoons.Models;
using System.Data.Entity;

namespace EightSpoons.Services
{
    public class PositionService : IPositionService
    {
        private EightSpoonsDB db = new EightSpoonsDB();

        public List<PositionViewModel> GetAll()
        {
            var positionList = db.Positions.ToList();
            return positionList.Select(pos => PosDto(pos)).ToList();
        }
        
        private static PositionViewModel PosDto(Position pos)
        {
            return new PositionViewModel
            {
                PositionId    = pos.PositionId,
                PositionTitle = pos.PositionTitle
            };
        }

        public PositionViewModel FindById(int id)
        {
            var position = db.Positions.Find(id);
            return position != null ? PosDto(position) : null;
        }
    }
}