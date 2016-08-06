namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    using Moq;
    using Data;

    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            //: this(new JustMockCarsRepository())
            : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void CarsController_Index_ShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        public void CarsController_Add_ShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => (Car)this.GetModel(() => this.controller.Add(null)));
        }

        [TestMethod]
        public void CarsController_Add_ShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            Assert.ThrowsException<ArgumentNullException>(() => (Car)this.GetModel(() => this.controller.Add(car)));
        }

        [TestMethod]
        public void CarsController_Add_ShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            Assert.ThrowsException<ArgumentNullException>(() => (Car)this.GetModel(() => this.controller.Add(car)));
        }

        [TestMethod]
        public void CarsController_Add_ShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void CarsController_Details_ShouldThrowArgumentNullExceptionIfIdIsNull()
        {
            var mockRepo = new Mock<ICarsRepository>();

            mockRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns((Car)null);
            var testController = new CarsController(mockRepo.Object);

            Assert.ThrowsException<ArgumentNullException>(() => testController.Details(10));
        }

        [TestMethod]
        public void CarsController_SearchingByCarMaker_ShouldReturnCorrecrResult()
        {
            var result = this.GetModel(() => this.controller.Search("BMW"));

            foreach (var car in (result as List<Car>))
            {
                Assert.AreEqual("BMW", car.Make);
            }
        }

        [TestMethod]
        public void CarsController_Sorting_ShouldReturnTrueIfCalledWithMake()
        {
            var mockedData = new Mock<IDatabase>();
            mockedData.Setup(x => x.Cars).Returns(new List<Car>());
            var carRepo = new CarsRepository(mockedData.Object);

            carRepo.Add(new Car
                        {
                            Id = 15,
                            Make = "BMW",
                            Model = "330d",
                            Year = 2014
                        });
                                
            carRepo.Add(new Car
                        {
                            Id = 15,
                            Make = "Audi",
                            Model = "330d",
                            Year = 2014
                        });

            var carsController = new CarsController(carRepo);

            var result = (List<Car>)carsController.Sort("make").Model;

            var isSorted = true;

            for (int i = 0; i < result.Count - 1; i++)
            {
                if (string.Compare(result[i].Make, result[i].Make) > 0)
                {
                    isSorted = false;
                }
            }

            Assert.IsTrue(isSorted);
        }

        [TestMethod]
        public void CarsController_Sorting_ShouldReturnTrueIfCalledWithYear()
        {
            var mockedData = new Mock<IDatabase>();
            mockedData.Setup(x => x.Cars).Returns(new List<Car>());
            var carRepo = new CarsRepository(mockedData.Object);

            carRepo.Add(new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2016
            });

            carRepo.Add(new Car
            {
                Id = 15,
                Make = "Audi",
                Model = "330d",
                Year = 2014
            });

            var carsController = new CarsController(carRepo);

            var result = (List<Car>)carsController.Sort("year").Model;

            var isSorted = true;

            for (int i = 1; i < result.Count; i++)
            {
                if (result[i].Year > result[i - 1].Year)
                {
                    isSorted = false;
                }
            }

            Assert.IsTrue(isSorted);
        }
    }
}
