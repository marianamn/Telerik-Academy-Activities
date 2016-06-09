using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtractStudentsInfo
{
    public class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;

        }

        public int GroupNumber 
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

        public string DepartmentName
        {
            get { return this.departmentName; }
            set { this.departmentName = value; }
        }
    }
}
