namespace _03.ReadFileContents
{
    using System;
    using System.IO;
    using System.Text;

    public class ReadFileContents
    {
        public static void Main()
        {
            try
            {
                using (StreamReader file = new StreamReader(@"C:\WINDOWS\win.ini", Encoding.UTF8))
                {
                    string readFile = file.ReadToEnd();
                    Console.WriteLine(readFile);
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("StreamReader invoked with wrong or null arguments");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("This method or functionality is not supported");
            }
        }
    }
}
