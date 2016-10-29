namespace CreateDbContext
{
    using System;
    using System.Linq;

    public class CreateDbContext
    {
        public static void Main()
        {
            using(var db = new NorthwindEntities())
            {
                var companies = db
                    .Customers
                    .Select(c => c.CompanyName)
                    .ToList();
                companies.ForEach(Console.WriteLine);
            }
        }
    }
}
