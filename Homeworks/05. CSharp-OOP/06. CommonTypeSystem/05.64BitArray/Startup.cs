namespace _05._64BitArray
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            BitArray array1 = new BitArray(357);
            BitArray array2 = new BitArray(123);

            Console.WriteLine("64 bit array1: {0}", array1);
            Console.WriteLine("64 bit array2: {0}", array2);
            Console.WriteLine();

            array1[1] = 0;

            Console.WriteLine("array2 hash code : {0}", array2.GetHashCode());
            Console.WriteLine("array1 == array2 : {0}", array1 == array2);
            Console.WriteLine("array1 != array2 : {0}", array1 != array2);
            Console.WriteLine("array1.Equals(array2) : {0}", array1.Equals(array2));
            Console.WriteLine();
        }
    }
}
