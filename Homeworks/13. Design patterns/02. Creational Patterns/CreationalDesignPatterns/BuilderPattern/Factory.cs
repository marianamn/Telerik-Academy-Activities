namespace BuilderPattern
{
    using System;

    /// <summary>
    /// The 'Director' class
    /// </summary>
    internal class Factory
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
            vehicleBuilder.BuildPaint();
        }
    }
}
