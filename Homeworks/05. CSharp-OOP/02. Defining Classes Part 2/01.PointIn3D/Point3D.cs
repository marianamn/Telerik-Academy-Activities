namespace _01.PointIn3D
{
    public struct Point3D
    {
        // problem 1
        private static readonly Point3D CenterO;            // add in problem 2
        private double x;
        private double y;
        private double z;
        
        static Point3D()
        {
            CenterO = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        
        public Point3D Center                             // add in problem 2
        {
            get { return CenterO; }
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public override string ToString()
        {
            return string.Format(
                                "Point Coordinates: \nx: {0:F2} \ny: {1:F2} \nz: {2:F2}",
                                 this.x, 
                                 this.y, 
                                 this.z);
        }
    }
}
