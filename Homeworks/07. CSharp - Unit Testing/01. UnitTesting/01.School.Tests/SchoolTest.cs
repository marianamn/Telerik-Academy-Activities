namespace _01.School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTesting
    {
        [TestMethod]
        public void School_ShouldBeCreatedWhenValidSchoolNameIsGiven()
        {
            School school = new School("Telerik Academy");

            string expectedName = "Telerik Academy";

            Assert.AreEqual(expectedName, school.Name, "School name is not valid!");
        }

        [TestMethod]
        public void School_ShouldThrowAnExceptionWhenCreatedWithNullSchoolName()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new School(null));
        }

        [TestMethod]
        public void School_ShouldThrowAnExceptionWhenCreatedWithEmptySchoolName()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new School(string.Empty));
        }

        [TestMethod]
        public void School_ShouldAddStudentsInSchool()
        {
            School school = new School("Telerik Academy");
            Student student = new Student(10006, "Ivan Ivanov");

            school.AddStudentInSchool(student);

            Assert.IsTrue(school.Students.Contains(student));
        }

        [TestMethod]
        public void School_ShouldThrowAnExceptionWhenTryToAddStudentsInSchoolWithSameId()
        {
            School school = new School("Telerik Academy");
            Student student = new Student(10006, "Ivan Ivanov");

            school.AddStudentInSchool(student);

            Assert.ThrowsException<ArgumentException>(() => school.AddStudentInSchool(student));
        }

        [TestMethod]
        public void School_ShouldRemoveStudentFromSchool()
        {
            School school = new School("Telerik Academy");
            Student student = new Student(10005, "Ivan Ivanov");

            school.RemoveStudentInSchool(student);

            Assert.IsFalse(school.Students.Contains(student));
        }

        [TestMethod]
        public void School_ShouldAddCourceToSchool()
        {
            School school = new School("Telerik Academy");
            Course course = new Course("High quality code");

            school.AddCourseToSchool(course);

            Assert.IsTrue(school.Courses.Contains(course));
        }

        [TestMethod]
        public void School_ShouldRemoveCourceFromSchool()
        {
            School school = new School("Telerik Academy");
            Course course = new Course("High quality code");

            school.RemoveCourseToSchool(course);

            Assert.IsFalse(school.Courses.Contains(course));
        }
    }
}
