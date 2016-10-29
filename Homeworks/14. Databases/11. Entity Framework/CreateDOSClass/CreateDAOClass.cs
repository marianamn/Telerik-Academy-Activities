namespace FindCustomers
{
    using System;
    using System.Linq;
    using CreateDbContext;

    public class CreateDAOClass
    {
        private static NorthwindEntities db;
        private static int affectedRows;

        public static void Main()
        {
            using (db = new NorthwindEntities())
            {
                InsertNewCustomersToDb();

                ModifyNewInsertedCustomer();

                // Exception will be thrown because of foreign key violation
                DeleteNewInsertedCustomer();
            }
        }

        private static void InsertNewCustomersToDb()
        {
            var newCustomer = new Customer
            {
                CustomerID = "NewID",
                CompanyName = "Telerik",
                ContactName = "Pesho",
                ContactTitle = "CEO",
                Address = "Sofia, 100",
                City = "Sofia",
                PostalCode = "1000",
                Country = "Bulgaria",
                Phone = "+3590000000",
                Fax = "123456"
            };

            db.Customers.Add(newCustomer);
            affectedRows = db.SaveChanges();

            Console.WriteLine("({0} row(s) affected)", affectedRows);
        }

        private static void ModifyNewInsertedCustomer()
        {
            var customer = db.Customers.First();
            customer.ContactTitle = "Sales Representative";
            affectedRows = db.SaveChanges();

            Console.WriteLine("({0} row(s) affected)", affectedRows);
        }

        private static void DeleteNewInsertedCustomer()
        {
            var customer = db.Customers.First();
            db.Customers.Remove(customer);
            affectedRows = db.SaveChanges();

            Console.WriteLine("({0} row(s) affected)", affectedRows);
        }
    }
}
