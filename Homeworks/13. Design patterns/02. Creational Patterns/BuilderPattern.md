# Creational Patterns Homework #

## Builder Pattern ##

----------

### Описание ###

Builder позволява създаването на сложен обект стъпка по стъпка използвайки конкретна поредица от действия, така че един и същи процес да може да създава обекти с различно представяне. Конструкцията се контролира от Директор.

### Цел ###

Целта е да се раздели създаването на сложен обект от неговото представяне (интерфейс), за да може с един и същ процес да се създават обекти с различно представяне.

### Употреба ###

* XML документи 

### Структура на design pattern-a###

![](/Images/BuilderStructure.png)


### Участници ###

* Director - контролира изпълнението стъпка по стъпка.
* Builder - абстрактен интерфейс за създаване на обекти.
* Concrete Builder - дава самата инплементация на Builder. Той е обект, който има възможността да конструира други обекти. Конструира и сглобява отделните части за изграждане на обектите.

### Свързани Design patterns ###

* Simple Factory
* Abstract Factory


### Имплементация ###

Пример за използване на Builder Pattern:

* Cъздаване на Vehicle Factory
* Cъздавене на две превозни средства - мотор и кола
* Последователни стъпки дефинирани от Директора - създаване на - двигател, колела, врати и боядисване

**Class diagram:**

![](/Images/BuilderExample.png)

**Code:**

    //class Vehicle
     internal class Vehicle
    {
        private readonly string vehicleType;
        private readonly Dictionary<string, string> parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get { return this.parts[key]; }
            set { this.parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("Vehicle Type: {0}", this.vehicleType);
            Console.WriteLine(" Engine : {0}", this.parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", this.parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", this.parts["doors"]);
            Console.WriteLine(" #Color : {0}", this.parts["color"]);
        }

    ----------------------------------------

    //VehicleBuilder
    internal abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; set; }

        public abstract void BuildEngine();

        public abstract void BuildWheels();

        public abstract void BuildDoors();

        public abstract void BuildPaint();
    }

    ----------------------------------------

    //MotorBuilder
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

    ----------------------------------------

    //CarBuilder
    internal class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            this.Vehicle = new Vehicle("Car");
        }

        public override void BuildEngine()
        {
            this.Vehicle["engine"] = "2500 cc";
        }

        public override void BuildWheels()
        {
            this.Vehicle["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            this.Vehicle["doors"] = "4";
        }

        public override void BuildPaint()
        {
            this.Vehicle["color"] = "red";
        }

    ----------------------------------------

    //Factory
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

    ----------------------------------------

    //Executor
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


 