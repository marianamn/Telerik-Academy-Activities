namespace _02.BunniesTask
{
    using System;
    using System.Text;
    using Contracts;
    using Extensions;

    [Serializable]
    public class Bunny
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public FurType FurType { get; set; }

        public void Introduce(IWriter writer)
        {
            writer.WriteLine(string.Format("{0} - I am {1} years old!", this.Name, this.Age));
            writer.WriteLine(string.Format("{0} - And I am {1}", this.Name, this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()));
        }

        public override string ToString()
        {
            var builderSize = 200;
            var builder = new StringBuilder(builderSize);

            builder.AppendLine(string.Format("Bunny name: {0}", this.Name));
            builder.AppendLine(string.Format("Bunny name: {0}", this.Age));
            builder.AppendLine(string.Format("Bunny name: {0}", this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()));

            return builder.ToString();
        }
    }
}
