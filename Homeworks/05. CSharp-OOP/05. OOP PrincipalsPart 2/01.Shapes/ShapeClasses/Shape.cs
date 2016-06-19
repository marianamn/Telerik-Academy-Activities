namespace _01.Shapes.ShapeClasses
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Shape(double width)
        {
            this.Width = width;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be positive number!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be positive number!");
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();

        public override string ToString()
        {
            return string.Format("width: {0:F2}, height: {1:F2}", this.width, this.height);
        }
    }
}
