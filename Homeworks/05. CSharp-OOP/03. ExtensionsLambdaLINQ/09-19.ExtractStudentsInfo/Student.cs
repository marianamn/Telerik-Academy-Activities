namespace _09_19.ExtractStudentsInfo
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int facNumber;
        private string phone;
        private string email;
        private List<double> marks;
        private int groupNumber;

        public Student(string firstName, string lastName, int facNumber, string phone, string email, List<double> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacNumber = facNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

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
            get
            {
                return this.lastName;
            }

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
            get
            {
                return this.facNumber;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Faculty number cannot be null or less than null!");
                }

                this.facNumber = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phone number cannot be null or empty");
                }

                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

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
            get
            {
                return this.marks;
            }

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
            get
            {
                return this.groupNumber;
            }

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
            return string.Format(
                                "{0} {1}, FN:{2}, GSM:{3}, mail:{4}, group:{5}, marks:{6}",
                                 this.FirstName,
                                 this.LastName,
                                 this.facNumber,
                                 this.Phone,
                                 this.Email,
                                 this.GroupNumber,
                                 string.Join(", ", this.Marks));
        }
    }
}
