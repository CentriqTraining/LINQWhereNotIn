using System.Data.Entity;
using System.Linq;

namespace ConsoleApplication14
{
    internal class Init : DropCreateDatabaseIfModelChanges<Ctx>
    {
        protected override void Seed(Ctx context)
        {
            //  Adds some sample data
            var ids = Enumerable.Range(1, 1000);
            foreach (var item in ids)
            {
                context.Bookings.Add(new Booking() {  MiscFieldForSample = item.ToString() });
            }

            var avoids = Enumerable.Range(400, 600);

            foreach (var item in avoids)
            {
                context.Exclusions.Add(new ExclusionList() { PersonID = item });
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}