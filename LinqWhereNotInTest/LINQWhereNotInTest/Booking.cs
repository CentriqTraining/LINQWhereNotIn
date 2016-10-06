using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    public class Booking
    {
        public int ID { get; set; }
        public string MiscFieldForSample { get; set; }

    }
    public class ExclusionList
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
    }

    public class Ctx : DbContext
    {
        public Ctx()
        {
            Database.SetInitializer<Ctx>(new Init());
        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<ExclusionList> Exclusions { get; set; }
    }
}
