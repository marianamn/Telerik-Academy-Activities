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

namespace CCars.Tests.JustMock.Controllers.CarsControllerTests
{
    [TestFixture]
    public class Search_Should
    {
        [Test]
        public void ReturnCar_WhenCarMakeIsFound()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };
            List<Car> data = new List<Car>();
            data.Add(car);

            var mockedCarsRepository = new Mock<ICarsRepository>();
            var carsController = new CarsController(mockedCarsRepository.Object);

            mockedCarsRepository.Setup(x => x.Search("BMW")).Returns(data);

            var model = (List<Car>)carsController.Search("BMW").Model;

            Assert.AreEqual(15, model.First().Id);
            Assert.AreEqual("BMW", model.First().Make);
            Assert.AreEqual("330d", model.First().Model);
            Assert.AreEqual(2014, model.First().Year);
        }
    }
}
