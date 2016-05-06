/*Problem 11. Binary search
 • Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.
 On the first line you will receive the number N
 On the next N lines the numbers of the array will be given
 On the last line you will receive the number X

 Print the index where X is in the array
 If there is more than one occurence print the first one
 If there are no occurences print -1
 */

using System;
class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int key = int.Parse(Console.ReadLine());

        Array.Sort(array);

        bool isSuchNumber = false;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == key)
            {
                isSuchNumber = true;
            }
        }

        if (!isSuchNumber)
        {
            Console.WriteLine("-1");
        }
        else
        {
            int imin = 0;
            int imax = n;

            while (imax >= imin)
            {
                int imid = imin + ((imax - imin) / 2);  // calculate the midpoint for roughly equal partition

                if (array[imid] == key)
                {
                    Console.WriteLine("{0}", imid);  // key found at index imid
                    break;
                }
                else if (array[imid] < key)         // determine which subarray to search
                {
                    imin = imid + 1;                // change min index to search upper subarray
                }
                else
                {
                    imax = imid - 1;                // change max index to search lower subarray
                }
            }
        }
    }
}


///more UI specified solution
///
//using System;
//class BinarySearch
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter array lenght: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] array = new int[n];
//
//        Console.WriteLine("Enter first int array: ");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("array[{0}] = ", i);
//            array[i] = int.Parse(Console.ReadLine());
//        }
//
//
//
//        Console.WriteLine();
//        Console.WriteLine("Select number from the above array: ");
//        int key = int.Parse(Console.ReadLine());
//
//
//        Array.Sort(array);
//        int imin = 0;
//        int imax = n;
//
//        while (imax >= imin)
//        {
//            int imid = imin + ((imax - imin) / 2);  // calculate the midpoint for roughly equal partition
//            if (array[imid] == key)
//            {
//                Console.WriteLine("index[{0}]", imid);  // key found at index imid
//                break;
//            }
//            else if (array[imid] < key)         // determine which subarray to search
//            {
//                imin = imid + 1;                // change min index to search upper subarray
//            }
//            else
//            {
//                imax = imid - 1;                // change max index to search lower subarray
//            }
//        }
//
//    }
//}

