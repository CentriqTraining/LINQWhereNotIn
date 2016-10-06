using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new Ctx();
            ctx.Database.Log = (p) => Console.WriteLine(p);

            var all = (from p in ctx.Bookings
                      where !(from a in ctx.Exclusions
                              select a.PersonID).Contains(p.ID)
                      select p).ToList();
        }
    }
}
