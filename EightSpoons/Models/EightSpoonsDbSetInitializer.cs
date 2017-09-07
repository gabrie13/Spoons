using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EightSpoons.Models;

namespace EightSpoons.Models
{
    public class EightSpoonsDbSetInitializer : DropCreateDatabaseAlways<EightSpoonsDB>
    {
        protected override void Seed(EightSpoonsDB context)
        {
            base.Seed(context);
        }
    }
}