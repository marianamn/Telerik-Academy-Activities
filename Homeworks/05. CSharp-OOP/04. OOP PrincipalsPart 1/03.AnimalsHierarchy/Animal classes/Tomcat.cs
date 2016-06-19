namespace _03.AnimalsHierarchy.Animal_classes
{
    using System;

    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age, Gender gender = Gender.Male)
            : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Tomcat {0} said: miau miau", this.Name);
        }
    }
}
