namespace _01._03.Student
{
    using System;

    public class Student : ICloneable, IComparable
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int socialNumber;
        private string address;
        private string phone;
        private string email;
        private int course;
        private Specialties specialty;
        private Universities university;
        private Faculties faculty;

        public Student(
            string firstName, 
            string middleName, 
            string lastName, 
            int socialNumber, 
            string address,
            string phone, 
            string email, 
            int course, 
            Universities university, 
            Faculties faculty,
            Specialties specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialNumber = socialNumber;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be epty, null or white space!");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Middle name cannot be epty, null or white space!");
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be epty, null or white space!");
                }

                this.lastName = value;
            }
        }

        public int SocialNumber
        {
            get
            {
                return this.socialNumber;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Social number cannot be null or negative!");
                }

                this.socialNumber = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Address cannot be epty, null or white space!");
                }

                this.address = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Phone cannot be epty, null or white space!");
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

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Email cannot be epty, null or white space!");
                }

                this.email = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Cource number cannot be null or negative!");
                }

                this.course = value;
            }
        }

        public Universities University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public Faculties Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        public Specialties Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !Student.Equals(student1, student2);
        }

        public override string ToString()
        {
            return string.Format(
                                "  Name: {0} {1} {2} \n  Social num: {3} \n  Mobile phone: {4} \n  E-mail: {5} \n  Cource: {6} \n  University: {7} \n  Faculty: {8} \n  Specialty: {9}",
                                this.firstName.ToString(), 
                                this.middleName.ToString(), 
                                this.lastName.ToString(), 
                                this.socialNumber,
                                this.phone.ToString(),
                                this.email.ToString(), 
                                this.course, 
                                this.university, 
                                this.faculty,
                                this.specialty);
        }

        public override int GetHashCode()
        {
            return this.firstName.GetHashCode() ^ this.lastName.GetHashCode();
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (this.firstName != student.firstName)
            {
                return false;
            }

            if (this.LastName != student.LastName)
            {
                return false;
            }

            if (this.University != student.University)
            {
                return false;
            }

            return true;
        }

        public object Clone()
        {
            Student original = this;
            Student newStudent = new Student(
                original.FirstName, 
                original.MiddleName, 
                original.LastName, 
                original.SocialNumber,
                original.Address, 
                original.Phone, 
                original.Email, 
                original.Course,
                original.University, 
                original.Faculty, 
                original.Specialty);

            return newStudent;
        }

        public int CompareTo(object obj)
        {
            var otherStudent = obj as Student;

            if (this.FirstName.CompareTo(otherStudent.FirstName) != 0)
            {
                return this.FirstName.CompareTo(otherStudent.FirstName);
            }

            if (this.MiddleName.CompareTo(otherStudent.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(otherStudent.MiddleName);
            }

            if (this.LastName.CompareTo(otherStudent.LastName) != 0)
            {
                return this.LastName.CompareTo(otherStudent.LastName);
            }

            if (this.SocialNumber.CompareTo(otherStudent.SocialNumber) != 0)
            {
                return this.SocialNumber.CompareTo(otherStudent.SocialNumber);
            }

            return 0;
        }
    }
}