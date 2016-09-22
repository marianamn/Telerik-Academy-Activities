using System;

namespace MatrixRefactoring
{
    public class Startup
    {
        public static void Main()
        {
            int rows = 6;
            int cols = 7;
            int startIndex = 12;

            Matrix matrix = new Matrix(rows, cols, startIndex);
            Console.WriteLine("Print initial blank matrix:\n{0}", matrix);

            matrix.FillMatrix();
            Console.WriteLine("Print filled matrix starting from start index {0}:\n{1}", startIndex, matrix);
        }
    }
}
