namespace AddNuewProduct
{
    using System;
    using System.Data.SqlClient;

    class AddNewProduct
    {
        static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " + "Database=Northwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand comand = new SqlCommand("DECLARE @name nchar(50) = 'Pesho' " +
                                                    "INSERT INTO Products (ProductName) "+
                                                    "VALUES (@name)", dbCon);
                
                var reader = comand.ExecuteReader();

                Console.WriteLine("NewProduct in Products table has been added");
            }
        }
    }
}
