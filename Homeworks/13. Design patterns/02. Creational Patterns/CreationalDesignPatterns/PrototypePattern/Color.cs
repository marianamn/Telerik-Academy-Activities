namespace PrototypePattern
{
    using System;

    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    public class Color : ColorPrototype
    {
        public Color(int red, int green, int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }

        public int Red { get; set; }

        public int Green { get; set; }

        public int Blue { get; set; }

        // Create a shallow copy
        public override ColorPrototype Clone()
        {
            return this.MemberwiseClone() as Color;
        }

        public override string ToString()
        {
            return string.Format("RGB = {0},{1},{2}", this.Red, this.Green, this.Blue);
        }
    }
}
