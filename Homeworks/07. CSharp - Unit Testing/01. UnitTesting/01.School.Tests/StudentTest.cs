namespace _01.School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void Student_ShouldBeCreatedWhenValidIdIsGiven()
        {
            Student student = new Student(10000, "Ivan Ivanov");

            int expectedId = 10000;

            Assert.AreEqual(expectedId, student.Id, "Student Id is not valid!");
        }

        [TestMethod]
        public void Student_ShouldBeCreatedWhenValidStudentNameIsGiven()
        {
            Student student = new Student(10000, "Ivan Ivanov");

            string expectedName = "Ivan Ivanov";

            Assert.AreEqual(expectedName, student.Name, "Student name is not valid!");
        }

        [TestMethod]
        public void Student_ShouldThrowAnExceptionWhenCreatedWithIdLowerThanIdMinValue()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Student(1, "Ivan Ivanov"));
        }

        [TestMethod]
        public void Student_ShouldThrowAnExceptionWhenCreatedWithHigherThanIdMaxValue()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Student(150000, "Ivan Ivanov"));
        }

        [TestMethod]
        public void Student_ShouldThrowAnExceptionWhenCreatedWithNullName()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Student(10005, null));
        }

        [TestMethod]
        public void Student_ShouldThrowAnExceptionWhenCreatedWithEmptyName()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Student(10005, string.Empty));
        }
    }
}

