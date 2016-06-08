namespace _02.GenericList
{
    using System;

    public class GenericListStart
    {
        public static void Main()
        {
            double a = 45;
            double b = 34.45;
            double c = -102.24;

            GenericList<double> testList = new GenericList<double>(10);
            testList.AddElement(a);
            testList.AddElement(b);
            testList.AddElement(c);
            Console.WriteLine("Numbers were added to list. \nList:");
            PrintList(testList);
            Console.WriteLine();

            testList.RemoveElementAtIndex(2);
            Console.WriteLine("Removed element at index 2. \nList:");
            PrintList(testList);
            Console.WriteLine();

            testList.InsertElementAtIndex(1, 200);
            Console.WriteLine("Inserted element at index 1. \nList:");
            PrintList(testList);
            Console.WriteLine();

            Console.WriteLine("Find element with value = 200 and return 1 if such exist");
            Console.WriteLine(testList.FindElementByValue(200));

            Console.WriteLine();
            Console.WriteLine("Min value = {0}\nMax value = {1}", testList.Min(), testList.Max());
            Console.WriteLine();

            testList.Clear();
            Console.WriteLine("List was cleared!\nList:");
            PrintList(testList);
            Console.WriteLine();
        }

        private static void PrintList(GenericList<double> testList)
        {
            for (int i = 0; i < testList.Count; i++)
            {
                if (i < testList.Count - 1)
                {
                    Console.Write("{0}, ", testList[i]);
                }
                else
                {
                    Console.Write(testList[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
