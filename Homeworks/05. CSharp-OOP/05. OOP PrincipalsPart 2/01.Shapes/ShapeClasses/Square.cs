namespace _01.Shapes.ShapeClasses
{
    public class Square : Rectangle
    {
        public Square(double width)
            : base(width)
        {
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Width;
            return surface;
        }

        public override string ToString()
        {
            return string.Format("width: {0:F2}", this.Width);
        }
    }
}
