namespace ReadFromExcel
{
    using System;
    using System.Data.OleDb;

    public class ReadFomAndWriteInExcel
    {
        static void Main()
        {
            string connectionString = @"Provider= Microsoft.ACE.OLEDB.12.0;Data Source = ..\..\Scores.xlsx;Extended Properties = ""Excel 12.0 Xml;HDR=YES"";";

            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();

            using (dbConnection)
            {
                // 6.Create an Excel file with 2 columns: name and score
                GetDataFromExcelFile(dbConnection);
                Console.WriteLine();

                // 7.Implement appending new rows to the Excel file.
                AddingNewRowToExcelFile(dbConnection, "Pesho", 34);
                AddingNewRowToExcelFile(dbConnection, "Gosho", 43);
            }
        }

        private static void AddingNewRowToExcelFile(OleDbConnection dbConnection, string name, double score)
        {
            OleDbCommand cmd = new OleDbCommand(
               string.Format("INSERT INTO [Sheet1$] (Name, Score) VALUES ('{0}', '{1}')", name, score), dbConnection);

            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Row inserted successfully.");
            }
            catch (OleDbException exception)
            {
                Console.WriteLine("Excel Error occured: " + exception);
            }
        }

        private static void GetDataFromExcelFile(OleDbConnection dbConnection)
        {
            string xslStringCommand = @"
                    SELECT *
                    FROM [Sheet1$]";

            OleDbCommand xslCommand = new OleDbCommand(xslStringCommand, dbConnection);
            OleDbDataReader reader = xslCommand.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    double score = (double)reader["Score"];
                    Console.WriteLine("{0} -> {1}", name, score);
                }
            }
        }
    }
}
