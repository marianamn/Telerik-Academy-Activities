namespace NumberOfCategories
{
    using System;
    using System.Data.SqlClient;

    class NumberOfRowsInCategoriesTable
    {
        static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " + "Database=Northwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand cmdCount = new SqlCommand(
                    "SELECT COUNT(*) FROM Categories", dbCon);
                int categoryRowsCount = (int)cmdCount.ExecuteScalar();
                Console.WriteLine("Category table rows count: {0} ", categoryRowsCount);
            }
        }
    }
}
