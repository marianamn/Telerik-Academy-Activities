namespace _03.AnimalsHierarchy.Animal_classes
{
    using System;

    public class Kitten : Cat, ISound
    {
        public Kitten(string name, int age, Gender gender = Gender.Female)
            : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Kitten {0} said: mrrrrr", this.Name);
        }
    }
}
