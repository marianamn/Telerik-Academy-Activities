# Creational Patterns Homework #

## Prototype Pattern ##

----------

### Описание ###
Prototype pattern създава обекти с помощта на обект-прототип. Новите обекти се създават чрез клониране на прототипа, вместо с използване на конструктор.


### Цел ###

* Избягва създаването на нов обект(копие), което използва много повече ресурси, отколкото ако го клонираме.
* Скрива сложността от вземане на нови инстанции на обекта от страна на клиента


### Употреба ###

* При копиране на web ресурс (вместо свалянето му, всеки път, когато е необходим).
* При копиране на текущото състояние на обекта.
* При криене на констуктора и позволено клониране
* JavaScript - прототипен език


### Структура на design pattern-a###

![](/Images/PrototypeStructure.png)


### Участници ###

* Prototype - декларира интерфейса за клониране на себе си
* ConcretePrototype - имплеменитра операциите за клониране на себе си
* Client - създава нов обект, чрез искане към прототипа да се клонира

### Свързани Design patterns ###

* Abstract Factory Pattern
* Factory method


### Имплементация ###


Пример за използване на Builder Pattern:

* Cъздаване на Color Manager
* Cъздаване на абстрактен клас Color Prototype - с метод Clone()
* Създаване на клас Color, който наследява Color Prototype

**Class diagram:**

![](/Images/PrototypeExample.png)

**Code:**

    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }

    ----------------------------------------

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

    ----------------------------------------

    public class PrototypePatternExecutor
    {
        static void Main(string[] args)
        {
            Color color = new Color(255, 0, 0);
            Color anothercolor = color.Clone() as Color;

            Console.WriteLine("Initial color " + color);
            Console.WriteLine("Cloned color " + anothercolor);

            color.Blue = 100;
            Console.WriteLine("Initial color " + color);
        }
    }
