using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EightSpoons.Models
{
    public class EightSpoonsDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EightSpoonsDB() : base("name=EightSpoonsDB")
        {
        }

        public System.Data.Entity.DbSet<EightSpoons.Models.Location> Locations { get; set; }

        public System.Data.Entity.DbSet<EightSpoons.Models.Position> Positions { get; set; }

        public System.Data.Entity.DbSet<EightSpoons.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<EightSpoons.Models.Register> Registers { get; set; }
    }
}
