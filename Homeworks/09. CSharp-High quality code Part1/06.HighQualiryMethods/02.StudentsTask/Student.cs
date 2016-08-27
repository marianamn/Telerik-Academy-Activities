using System;
using System.Globalization;

namespace _02.StudentsTask
{
    public class Student
    {
        private const string DateFormat = "dd.MM.yyyy";
        private const int DateFormatLength = 10;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BirthDate { get; set; }

        public bool CheckIsStudentOlderThan(Student stuednt)
        {
            DateTime firstDate = DateTime.ParseExact(
                this.BirthDate.Substring(this.BirthDate.Length - DateFormatLength), 
                DateFormat, 
                CultureInfo.InvariantCulture);

            DateTime secondDate = DateTime.ParseExact(
                stuednt.BirthDate.Substring(stuednt.BirthDate.Length - DateFormatLength),
                DateFormat, 
                CultureInfo.InvariantCulture);

            int result = DateTime.Compare(firstDate, secondDate);
            bool isFirstStudentOlder = false;

            if (result == 1 || result == 0)
            {
                isFirstStudentOlder = false;
            }
            else
            {
                isFirstStudentOlder = true;
            }

            return isFirstStudentOlder;
        }
    }
}