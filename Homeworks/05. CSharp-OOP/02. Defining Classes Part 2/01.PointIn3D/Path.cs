namespace _01.PointIn3D
{
    using System.Collections.Generic;

    public class Path
    {
        // problem 4
        private List<Point3D> pathList;

        public Path(List<Point3D> pathList)
        {
            this.PathList = pathList;
        }
        
        public List<Point3D> PathList
        {
            get { return this.pathList; }
            set { this.pathList = value; }
        }
    }
}
