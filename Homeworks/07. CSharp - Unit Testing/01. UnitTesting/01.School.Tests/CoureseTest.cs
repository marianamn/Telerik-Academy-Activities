namespace _01.School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CoureseTest
    {
        private const int MaxAllowedtudentsInCourse = 30;

        [TestMethod]
        public void Course_ShouldBeCreatedWhenValidCourseNameIsGiven()
        {
            Course course = new Course("High quality code");

            string expectedName = "High quality code";

            Assert.AreEqual(expectedName, course.Name, "Course name is not valid!");
        }

        [TestMethod]
        public void Course_ShouldThrowAnExceptionWhenCreatedWithNullCourseName()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Course(null));
        }

        [TestMethod]
        public void Course_ShouldThrowAnExceptionWhenCreatedWithEmptyCourseName()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Course(string.Empty));
        }

        [TestMethod]
        public void Course_ShouldReturnTrueIfValidStudentIsSuccessfullyAddedToCourse()
        {
            Course course = new Course("High quality code");
            Student student = new Student(10005, "Ivan Ivanov");

            course.AddStudentInCourse(student);

            Assert.IsTrue(course.Students.Contains(student));
        }

        [TestMethod]
        public void Course_ShouldThrowAnExceptionWhenNullStudentIsAddedToCourse()
        {
            Course course = new Course("High quality code");

            Assert.ThrowsException<ArgumentNullException>(() => course.AddStudentInCourse(null));
        }
        
        [TestMethod]
        public void Course_ShouldThrowAnExceptionWhenAddingValidStudentsInCourseMoreThanMaxAllowedCount()
        {
            Course course = new Course("High quality code");
            Student student = new Student(10005, "Ivan Ivanov");

            for (int i = 0; i < MaxAllowedtudentsInCourse + 1; i++)
            {
                course.AddStudentInCourse(student);
            }

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => course.AddStudentInCourse(student));
        }

        [TestMethod]
        public void Course_ShouldRemoveStudentFromCourse()
        {
            Course course = new Course("High quality code");
            Student student = new Student(10005, "Ivan Ivanov");
            
            course.RemoveStudentFromCourse(student);

            Assert.IsFalse(course.Students.Contains(student));
        }

        [TestMethod]
        public void Course_ShouldThrowAnExceptionWhenNullStudentIsRemovedFromCourse()
        {
            Course course = new Course("High quality code");

            Assert.ThrowsException<ArgumentNullException>(() => course.RemoveStudentFromCourse(null));
        }
    }
}
