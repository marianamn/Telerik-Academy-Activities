namespace FindSalesBySpecificRegionsAndPeriod
{
    using System;
    using System.Linq;
    using CreateDbContext;

    internal class FindSalesBySpecificRegionsAndPeriod
    {
        private static NorthwindEntities db;

        public static void Main()
        {
            const string region = "WA";
            var startDate = new DateTime(1996, 7, 31);
            var endDate = new DateTime(1996, 12, 31);

            using (db = new NorthwindEntities())
            {
                var sales = db.Orders
                            .Where(o => o.ShipRegion == region &&
                                        o.OrderDate >= startDate &&
                                        o.OrderDate <= endDate)
                            .ToList();

                foreach (var sale in sales)
                {
                    Console.WriteLine("Order to region {0}, ordered on {1}, shipped to {2}",
                                      sale.ShipRegion, 
                                      sale.OrderDate, 
                                      sale.ShipCountry);
                }
            }
        }
    }
}
