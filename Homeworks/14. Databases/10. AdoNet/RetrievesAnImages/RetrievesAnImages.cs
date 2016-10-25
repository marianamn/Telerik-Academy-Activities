namespace RetrievesAnImages
{
    using System;
    using System.Configuration;
    using System.IO;
    using System.Drawing;
    using System.Data.SqlClient;
    using System.Data.OleDb;

    class RetrievesAnImages
    {
        private const int OLE_METAFILEPICT_START_POSITION = 78;

        static void Main(string[] args)
        {
        
            string connectionString = "Server=.\\SQLEXPRESS; " + "Database=Northwind; Integrated Security=true";
            byte[] image = null;
            SqlConnection dbCon = new SqlConnection(connectionString);
            dbCon.Open();
            
            using (dbCon)
            {
                SqlCommand cmd = new SqlCommand("SELECT Picture FROM Categories", dbCon);
                SqlDataReader reader = cmd.ExecuteReader();

                var count = 0;
                string filePath;

                while (reader.Read())
                {
                    filePath = String.Format(@"..\..\CategoryPicture{0}.jpg", count);
                    image = (byte[])reader["Picture"];
                    WiriteImageFile(filePath, image);
                    count++;
                }

                Console.WriteLine("Images has been written in the directory!");
            }
        }

        private static void WiriteImageFile(string fileName, byte[] fileContents)
        {
            using (var ms = new MemoryStream(fileContents, OLE_METAFILEPICT_START_POSITION, fileContents.Length - OLE_METAFILEPICT_START_POSITION))
            {
                Image img = Image.FromStream(ms);

                img.Save(fileName);
            }
        }
    }
}
