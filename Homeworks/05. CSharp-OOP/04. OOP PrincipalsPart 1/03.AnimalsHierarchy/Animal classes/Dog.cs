namespace _03.AnimalsHierarchy.Animal_classes
{
    using System;

    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public void Print()
        {
            Console.WriteLine("Dogs:\n");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Dog {0} said: bau", this.Name);
        }
    }
}
