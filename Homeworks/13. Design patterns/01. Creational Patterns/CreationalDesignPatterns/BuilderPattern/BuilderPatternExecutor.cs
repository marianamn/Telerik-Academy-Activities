namespace BuilderPattern
{
    using System;

    internal class BuilderPatternExecutor
    {
        internal static void Main()
        {
            VehicleBuilder builder;
            var factory = new Factory();

            builder = new CarBuilder();
            factory.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorBuilder();
            factory.Construct(builder);
            builder.Vehicle.Show();
        }
    }
}
