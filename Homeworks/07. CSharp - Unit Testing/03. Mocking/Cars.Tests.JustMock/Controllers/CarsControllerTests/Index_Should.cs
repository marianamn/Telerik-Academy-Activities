namespace Cars.Tests.JustMock.Controllers.CarsControllerTests
{
    using Cars.Contracts;
    using Cars.Controllers;
    using Models;
    using Moq;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    public class Index_Should
    {
        [Test]
        public void ReturnAllCars_WhenCalled()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();
            mockedCarsRepository.Setup(x => x.All());

            var carsController = new CarsController(mockedCarsRepository.Object);

            carsController.Index();

            mockedCarsRepository.Verify(x => x.All(), Times.Once);
        }
    }
}
