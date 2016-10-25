namespace AllCategoriesWithProducts
{
    using System;
    using System.Data.SqlClient;

    class AllCategoriesWithProducts
    {
        static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " + "Database=Northwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand comand = new SqlCommand("SELECT c.CategoryName, p.ProductName " +
                                                   "FROM Categories c " +
                                                   "INNER JOIN Products p " +
                                                   "ON p.CategoryID = c.CategoryID " +
                                                   "ORDER BY c.CategoryName", dbCon);

                var reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("{0} --> {1}", reader["CategoryName"], reader["ProductName"]);
                }
            }
        }
    }
}
