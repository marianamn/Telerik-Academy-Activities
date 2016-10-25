namespace ReadStrindFromConsole
{
    using System;
    using System.Data.SqlClient;

    public class ReadFromConsole
    {
        static void Main()
        {
            string connectionString = "Server=.\\SQLEXPRESS; " + "Database=Northwind; Integrated Security=true";
            SqlConnection dbCon = new SqlConnection(connectionString);

            Console.Write("Please enter text to search product:");
            string input = Console.ReadLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Products that contain: {0}", input);
            SearchAllProductsThatContainString(dbCon, input);
        }

        private static void SearchAllProductsThatContainString(SqlConnection dbConnection, string input)
        {
            input = EscapeInputString(input);

            string sqlStringCommand = string.Format(@"
                    SELECT ProductName
                    FROM Products
                    WHERE ProductName LIKE '%{0}%'", input);

            SqlCommand allProducts = new SqlCommand(sqlStringCommand, dbConnection);
            SqlDataReader reader = allProducts.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string productName = (string)reader["ProductName"];
                    Console.WriteLine("{0}", productName);
                }
            }
        }

        private static string EscapeInputString(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '\'')
                {
                    input = input.Substring(0, i) + "'" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '_')
                {
                    input = input.Substring(0, i) + "/" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '%')
                {
                    input = input.Substring(0, i) + "\\" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '&')
                {
                    input = input.Substring(0, i) + "\\" + input.Substring(i, input.Length - i);
                    i++;
                }
            }
            return input;
        }
    }
}
