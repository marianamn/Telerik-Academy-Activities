namespace GSM
{
    using System;

    public class Display
    {
        // problem 1
        private double size;
        private int numberOfColors;

        // problem 2
        public Display()
        {
        }

        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        // problem 5
        public double Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                if (value == 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Display size should be > 0 and <= 10");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            private set
            {
                if (value < 256 || value > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Number of display colors should be > 255 and <= int.MaxValue");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }

        // problem 4
        public override string ToString()
        {
            return string.Format(
                                "Display size: {0} \nNumbers of display colors: {1}",
                                this.Size,
                                this.NumberOfColors);
        }
    }
}
