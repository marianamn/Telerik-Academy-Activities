namespace CategoriesNames
{
    using System;
    using System.Data.SqlClient;

    class CategoriesNames
    {
        static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " + "Database=Northwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand comand= new SqlCommand("SELECT CategoryName FROM Categories", dbCon);
                var reader = comand.ExecuteReader();

                Console.WriteLine("Category table categories names:");
                while (reader.Read())
                {
                    Console.WriteLine(reader["CategoryName"]);
                }
            }
        }
    }
}
