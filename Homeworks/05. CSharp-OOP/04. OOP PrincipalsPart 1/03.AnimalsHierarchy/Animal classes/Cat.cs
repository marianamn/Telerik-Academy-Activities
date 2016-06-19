namespace _03.AnimalsHierarchy.Animal_classes
{
    using System;

    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cat {0} said: miau", this.Name);
        }
    }
}
