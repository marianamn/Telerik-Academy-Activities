namespace _04.PersonClass
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Person person1 = new Person("Ivan Ivanov", 35);
            Person person2 = new Person("Petar Georgiev", null);

            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}
