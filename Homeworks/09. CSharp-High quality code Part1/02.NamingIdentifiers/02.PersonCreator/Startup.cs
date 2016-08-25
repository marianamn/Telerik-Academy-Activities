namespace _02.PersonCreator
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Person firstPerson = new Person(2);
            Person secondPerson = new Person(3);

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
