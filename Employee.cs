using System;

namespace HRApplication
{
    public class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private string birthday;
        private string employeeType;
        private string employmentDate;
        private string dismissDate;
        private string hourlyRate;
        private int employeeStatusId;
        private string employeeStatusName;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string EmployeeType
        {
            get { return employeeType; }
            set { employeeType = value; }
        }
        public string EmploymentDate
        {
            get { return employmentDate; }
            set { employmentDate = value; }
        }
        public string DismissDate
        {
            get { return dismissDate; }
            set { dismissDate = value; }
        }
        public string HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }
        public int EmployeeStatusId
        {
            get { return employeeStatusId; }
            set { employeeStatusId = value; }
        }
        public string EmployeeStatusName
        {
            get { return employeeStatusName; }
            set { employeeStatusName = value; }
        }

    }
}
