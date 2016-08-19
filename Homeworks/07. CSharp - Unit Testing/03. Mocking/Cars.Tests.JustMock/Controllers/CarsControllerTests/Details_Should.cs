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
    public class Details_Should
    {
        [Test]
        public void ThrowNullReferenceException_WhenNullCarIsPassed()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();

            var carsController = new CarsController(mockedCarsRepository.Object);

            // there is no car with id=1
            Assert.Throws<ArgumentNullException>(() => carsController.Details(1));
        }

        [Test]
        public void DetailsMethodIsCalled_WhenValidCarIsPassed()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var mockedCarsRepository = new Mock<ICarsRepository>();

            var carsController = new CarsController(mockedCarsRepository.Object);
            mockedCarsRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(car);

            carsController.Details(car.Id);

            mockedCarsRepository.Verify(x => x.GetById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void ReturnsCarDetails_WhenValidCarIsPassed()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var mockedCarsRepository = new Mock<ICarsRepository>();

            var carsController = new CarsController(mockedCarsRepository.Object);
            mockedCarsRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(car);

            var model = (Car)carsController.Details(car.Id).Model;

            Assert.AreEqual(15, model.Id);
            Assert.AreEqual("BMW", model.Make);
            Assert.AreEqual("330d", model.Model);
            Assert.AreEqual(2014, model.Year);
        }
    }
}
