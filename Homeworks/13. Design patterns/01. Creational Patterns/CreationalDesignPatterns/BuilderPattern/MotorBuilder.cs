namespace BuilderPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'ConcreteBuilder' class
    /// </summary>
    internal class MotorBuilder : VehicleBuilder
    {
        public MotorBuilder()
        {
            this.Vehicle = new Vehicle("Motor");
        }

        public override void BuildEngine()
        {
            this.Vehicle["engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            this.Vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            this.Vehicle["doors"] = "0";
        }

        public override void BuildPaint()
        {
            this.Vehicle["color"] = "black";
        }
    }
}
