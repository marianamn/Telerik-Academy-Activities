namespace _02.PersonCreator
{
    public class Person
    {
        public Person(int age)
        {
            this.Age = age;

            if (age % 2 == 0)
            {
                this.Name = "Petar";
                this.Gender = Gender.Male;
            }
            else
            {
                this.Name = "Maria";
                this.Gender = Gender.Female;
            }
        }

        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format($"name: {this.Name}, age: {this.Age}, gender: {this.Gender}");
        }
    }
}
