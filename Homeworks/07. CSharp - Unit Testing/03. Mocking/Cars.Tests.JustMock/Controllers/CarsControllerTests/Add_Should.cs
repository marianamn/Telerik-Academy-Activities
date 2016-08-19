using Cars.Contracts;
using Cars.Controllers;
using Cars.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Tests.JustMock.Controllers.CarsControllerTests
{
    [TestFixture]
    public class Add_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenTryToAddNullCar()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var carsController = new CarsController(mockedCarsRepository.Object);

            Assert.Throws<ArgumentNullException>(() => carsController.Add(car));
        }

        [Test]
        public void ThrowArgumentNullException_WhenCarMakeIsNull()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();
            var car = new Car
            {
                Id = 15,
                Make = null,
                Model = "330d",
                Year = 2014
            };

            var carsController = new CarsController(mockedCarsRepository.Object);

            Assert.Throws<ArgumentNullException>(() => carsController.Add(car));
        }

        [Test]
        public void ThrowArgumentNullException_WhenCarMakeIsEmpty()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();
            var car = new Car
            {
                Id = 15,
                Make = string.Empty,
                Model = "330d",
                Year = 2014
            };

            var carsController = new CarsController(mockedCarsRepository.Object);

            Assert.Throws<ArgumentNullException>(() => carsController.Add(car));
        }

        [Test]
        public void ThrowArgumentNullException_WhenCarModelIsNull()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = null,
                Year = 2014
            };

            var carsController = new CarsController(mockedCarsRepository.Object);

            Assert.Throws<ArgumentNullException>(() => carsController.Add(car));
        }

        [Test]
        public void ThrowArgumentNullException_WhenCarModelIsEmpty()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = string.Empty,
                Year = 2014
            };

            var carsController = new CarsController(mockedCarsRepository.Object);

            Assert.Throws<ArgumentNullException>(() => carsController.Add(car));
        }

        [Test]
        public void AddCar_WhenCarPassedIsValid()
        {
            // Arrange
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var mockedCarsRepository = new Mock<ICarsRepository>();
            var carsController = new CarsController(mockedCarsRepository.Object);

            mockedCarsRepository.Setup(x => x.Add(It.IsAny<Car>()));
            mockedCarsRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(car);

            // Act
            carsController.Add(car);

            // Assert
            mockedCarsRepository.Verify(x => x.Add(car), Times.Once);
        }
    }
}
