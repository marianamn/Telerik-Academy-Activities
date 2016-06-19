namespace _01.Shapes
{
    using System;
    using ShapeClasses;

    public class Startup
    {
        public static void Main()
        {
            Shape[] shapes = 
            {
                new Triangle(2, 3),
                new Triangle(1.5, 2.1),
                new Triangle(5, 6),

                new Rectangle(1.5, 4),
                new Rectangle(3, 4),

                new Square(3),
                new Square(2.5),
                new Square(3.1),
            };

            foreach (var item in shapes)
            {
                Console.WriteLine(
                                  "Type: {0} {1}, surface: {2:F2}",
                                  item.GetType().Name.PadRight(10), 
                                  item,
                                  item.CalculateSurface());
            }

            Console.WriteLine();
        }
    }
}
