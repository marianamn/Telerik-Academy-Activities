namespace PrototypePattern
{
    using System;

    public class PrototypePatternExecutor
    {
        public static void Main(string[] args)
        {
            Color color = new Color(255, 0, 0);
            Color anothercolor = color.Clone() as Color;

            Console.WriteLine("Initial color " + color);
            Console.WriteLine("Cloned color " + anothercolor);

            color.Blue = 100;
            Console.WriteLine("Initial color " + color);
        }
    }
}
