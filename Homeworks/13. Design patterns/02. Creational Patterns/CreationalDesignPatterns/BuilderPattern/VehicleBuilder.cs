namespace BuilderPattern
{
    using System;

    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    internal abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; set; }

        public abstract void BuildEngine();

        public abstract void BuildWheels();

        public abstract void BuildDoors();

        public abstract void BuildPaint();
    }
}
