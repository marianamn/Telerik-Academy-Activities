namespace _03.AnimalsHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _03.AnimalsHierarchy.Animal_classes;

    public class Startup
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog("Sharo", 5, Gender.Male),
                new Dog("Rex", 10, Gender.Male),
                new Dog("Lucky", 7, Gender.Female),

                new Frog("Juju", 1, Gender.Female),
                new Frog("Pepe", 5, Gender.Male),

                new Cat("Octavius", 3, Gender.Male),
                new Tomcat("Tolking", 7, Gender.Male),
                new Tomcat("Tom", 2, Gender.Male),
                new Kitten("Fifi", 5, Gender.Female),
                new Kitten("Bibi", 4, Gender.Female)
            };

            Console.WriteLine("Initial Animals:");
            PrintCollection(animals);

            animals[1].MakeSound();
            animals[4].MakeSound();
            animals[5].MakeSound();
            animals[6].MakeSound();
            animals[8].MakeSound();

            Console.WriteLine();

            double avrgDogsAge = animals.Where(x => x is Dog).Average(x => x.Age);
            double avrgFrogsAge = animals.Where(x => x is Frog).Average(x => x.Age);
            double avrgCatsAge = animals.Where(x => x is Cat).Average(x => x.Age);
            double avrgTomcatsAge = animals.Where(x => x is Tomcat).Average(x => x.Age);
            double avrgKittenAge = animals.Where(x => x is Kitten).Average(x => x.Age);

            Console.WriteLine("Average dogs age: {0:F2}", avrgDogsAge);
            Console.WriteLine("Average frogs age: {0:F2}", avrgFrogsAge);
            Console.WriteLine("Average cats age: {0:F2}", avrgCatsAge);
            Console.WriteLine("Average Tomcats age: {0:F2}", avrgTomcatsAge);
            Console.WriteLine("Average Kitten age: {0:F2}", avrgKittenAge);
        }

        private static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine("Type:{0}, {1} ", item.GetType().Name, item);
            }

            Console.WriteLine();
        }
    }
}
