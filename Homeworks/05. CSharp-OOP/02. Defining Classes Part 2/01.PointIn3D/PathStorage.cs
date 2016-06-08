namespace _01.PointIn3D
{
    using System;
    using System.IO;

    // problem 4
    public class PathStorage
    {
        public static void SavePaths(Path path)
        {
            StreamWriter writeFile = new StreamWriter(@"..\..\Saved Points Path.txt");

            using (writeFile)
            {
                for (int i = 0; i < path.PathList.Count; i++)
                {
                    writeFile.WriteLine(path.PathList[i]);
                }
            }
        }

        public static void LoadPaths(Path path)
        {
            StreamReader readFile = new StreamReader(@"..\..\Saved Points Path.txt");

            using (readFile)
            {
                for (int i = 0; i < path.PathList.Count; i++)
                {
                    Console.WriteLine(path.PathList[i]);
                }
            }
        }
    }
}
