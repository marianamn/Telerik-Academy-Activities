namespace FindCustomerWithNativeSQL
{
    using System;
    using System.Linq;
    using CreateDbContext;

    internal class FindCustomerWithNativeSQL
    {
        private static NorthwindEntities db;

        public static void Main()
        {
            using (db = new NorthwindEntities())
            {
                var customers = db.Database.SqlQuery<View>("SELECT c.ContactName AS [Customer], o.OrderDate [Order Year], o.ShipCountry " +
                                                           "FROM Customers c " +
                                                           "INNER JOIN Orders o " +
                                                           "ON c.CustomerID = o.CustomerID " +
                                                           "WHERE YEAR (o.OrderDate) = 1997 AND o.ShipCountry = 'Canada'");

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }
        }
    }
}
