using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtractStudentsInfo
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int facNumber;
        private string phoneNumber;
        private string email;
        private List<double> marks;
        private int groupNumber;

        public Student (string firstName, string lastName, int facNumber,
                        string phoneNumber, string email, List<double> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacNumber = facNumber;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        public int FacNumber
        {
            get { return this.facNumber; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Faculty number cannot be null or less than null!");
                }

                this.facNumber = value;
            }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                       throw new ArgumentException("Phone number cannot be null or empty");
                }

                this.phoneNumber = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email number cannot be null or empty");
                }

                this.email = value;
            }
        }

        public List<double> Marks
        {
            get { return this.marks; }
            private set
            {
                foreach (var mark in value)
                {
                    if (mark < 2 && mark > 6)
                    {
                        throw new ArgumentOutOfRangeException("Marks must be between 2 and 6.");
                    }
                }

                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Group number cannot be null or less than null!");
                }

                this.groupNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0,-8} {1,-9} {2,-7} {3,-13} {4,-16} {5,-3} [{6}]", this.firstName.ToString(), 
                                 this.lastName.ToString(), this.facNumber, this.phoneNumber.ToString(),
                                 this.email.ToString(), this.groupNumber, string.Join(", ", this.marks)); //string.Join(", ", (from mk in this.Marks select mk.ToString()).ToArray()));
        }
    }
}
