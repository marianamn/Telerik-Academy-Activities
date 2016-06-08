namespace _03.DefinindMatrix
{
    using System;

    public class MatrixStart
    {
        public static void Main()
        {
            Matrix<int> testMatrix1 = new Matrix<int>(3, 3);
            Matrix<int> testMatrix2 = new Matrix<int>(3, 3);

            RandomGenerator(testMatrix1, testMatrix2);
            Console.WriteLine("Matrix 1: ");
            Console.WriteLine(testMatrix1);
            Console.WriteLine("Matrix 2: ");
            Console.WriteLine(testMatrix2);

            Console.WriteLine("Sum: ");
            Console.WriteLine(testMatrix1 + testMatrix2);
            Console.WriteLine("Substracting: ");
            Console.WriteLine(testMatrix1 - testMatrix2);
            Console.WriteLine("Multiplying: ");
            Console.WriteLine(testMatrix1 * testMatrix2);

            if (testMatrix1)
            {
                Console.WriteLine("Martix 1 does not contain zero elements");
            }
            else
            {
                Console.WriteLine("Martix 1 contains zero elements");
            }
        }

        private static void RandomGenerator(Matrix<int> testMatrix1, Matrix<int> testMatrix2)
        {
            Random randomGen = new Random();

            for (int i = 0; i < testMatrix1.Rows; i++)
            {
                for (int j = 0; j < testMatrix2.Cols; j++)
                {
                    testMatrix1[i, j] = randomGen.Next(10);
                    testMatrix2[i, j] = randomGen.Next(10);
                }
            }
        }
    }
}