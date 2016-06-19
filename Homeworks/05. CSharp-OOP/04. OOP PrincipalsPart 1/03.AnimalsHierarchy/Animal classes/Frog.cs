namespace _03.AnimalsHierarchy.Animal_classes
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Frog {0} said: kuak", this.Name);
        }
    }
}
