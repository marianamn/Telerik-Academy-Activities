using System;

namespace _01.RotateFigure
{
    public class Figure
    {
        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public static Figure RotateFigure(Figure figure, double rotateAngle)
        {
            double cosinusRotateAngleWidth = Math.Abs(Math.Cos(rotateAngle)) * figure.Width;
            double sinusRotateAngleHeight = Math.Abs(Math.Sin(rotateAngle)) * figure.Height;
            double sinusRotateAngleWidth = Math.Abs(Math.Sin(rotateAngle)) * figure.Width;
            double cosinusRotateAngleHeight = Math.Abs(Math.Cos(rotateAngle)) * figure.Height;

            double figureWidth = cosinusRotateAngleWidth + sinusRotateAngleHeight;
            double figureHeight = sinusRotateAngleWidth + cosinusRotateAngleHeight;

            Figure rotatedfigure = new Figure(figureWidth, figureHeight);

            return rotatedfigure;
        }
    }
}