namespace Cars.Tests.JustMock
{
    using Cars.Data;
    using Contracts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;
    using Moq;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class CarsRepositoryTests
    {
        private Car car = new Car
                        {
                            Id = 15,
                            Make = "Audi",
                            Model = "330d",
                            Year = 2014
                        };

        [TestMethod]
        public void CarsRepository_TotalCars_ShouldReturnToralCarsInCollectionOfcars()
        {
            //arrange
            var mockedCarsList = new Mock<IList<Car>>();
            mockedCarsList.Setup(x => x.Count).Returns(1);

            var mockedCarsDB = new Mock<IDatabase>();
            mockedCarsDB.Setup(x => x.Cars).Returns(mockedCarsList.Object);
            
            var carsRepository = new CarsRepository(mockedCarsDB.Object);

            //act
            var executeTotalCars = carsRepository.TotalCars;

            //assert
            mockedCarsDB.Verify(db => db.Cars, Times.Exactly(1));
        }

        [TestMethod]
        public void CarsRepository_AddCar_ShouldThrowAnExceptionWhenNullCarIsAdded()
        {
            var mockedCarsList = new Mock<IList<Car>>();
            mockedCarsList.Setup(x => x.Add(null)).Throws<ArgumentException>();
        }

        [TestMethod]
        public void CarsRepository_AddCar_ShouldAddCarProperly()
        {
            //arrange
            var mockedCarsList = new Mock<IList<Car>>();
            mockedCarsList.Setup(x => x.Add(this.car));

            var mockedCarsDB = new Mock<IDatabase>();
            mockedCarsDB.Setup(x => x.Cars).Returns(mockedCarsList.Object);
            
            var carsRepository = new CarsRepository(mockedCarsDB.Object);
            
            //act
            carsRepository.Add(this.car);

            //assert
            Assert.AreEqual(mockedCarsDB.Object.Cars.Count, carsRepository.TotalCars);
        }

        [TestMethod]
        public void CarsRepository_RemoveCar_ShouldThrowAnExceptionWhenNullCarIsRemoved()
        {
            var mockedCarsList = new Mock<IList<Car>>();
            mockedCarsList.Setup(x => x.Remove(null)).Throws<ArgumentException>();
        }

        [TestMethod]
        public void CarsRepository_RemoveCar_ShouldRemoveCarProperly()
        {
            //arrange
            var mockedCarsList = new Mock<IList<Car>>();
            mockedCarsList.Setup(x => x.Remove(this.car)).Verifiable();

            var mockedCarsDB = new Mock<IDatabase>();
            mockedCarsDB.Setup(x => x.Cars).Returns(mockedCarsList.Object);

            var carsRepository = new CarsRepository(mockedCarsDB.Object);

            //act
            carsRepository.Remove(this.car);

            //assert
            Assert.IsTrue(mockedCarsList.Object.Count == 0);
            Assert.IsTrue(carsRepository.TotalCars == 0);
        }

        [TestMethod]
        public void CarsRepository_GetById_ShouldThrowExceptionIfNullCarisPassed()
        {
            var mockedCarsList = new Mock<IList<Car>>();
            mockedCarsList.Setup(x => x.Add(It.IsAny<Car>())).Verifiable();
            mockedCarsList.Object.Add(this.car);

            var mockedCarsDB = new Mock<IDatabase>();
            mockedCarsDB.Setup(x => x.Cars).Returns(mockedCarsList.Object);

            var carsRepository = new CarsRepository(mockedCarsDB.Object);

            Assert.ThrowsException<ArgumentException>(() => carsRepository.Add(null));
        }
    }
}
