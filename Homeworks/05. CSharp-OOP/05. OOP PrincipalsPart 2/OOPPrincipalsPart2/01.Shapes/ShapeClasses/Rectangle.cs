namespace _01.Shapes.ShapeClasses
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }
        
        public Rectangle(double width)
            : base(width)
        {
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
