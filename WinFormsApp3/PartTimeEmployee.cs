using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInterface;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        private string employeeFirstName;
        private string employeeLastName;
        private string employeeDepartment;
        private string employeeJobTitle;
        private double employeeBasicSalary;

        public string firstName
        {
            get { return employeeFirstName; }
            set { employeeFirstName = value; }
        }

        public string lastName
        {
            get { return employeeLastName; }
            set { employeeLastName = value; }
        }

        public string department
        {
            get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }

        public string jobTitle
        {
            get { return employeeJobTitle; }
            set { employeeJobTitle = value; }
        }
        public double basicSalary
        {
            get { return employeeBasicSalary; }
            set { employeeBasicSalary = value; }
        }

        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
           this.employeeFirstName = FName;
           this.employeeLastName = LName;
           this.employeeDepartment = dept;
           this.employeeJobTitle = job;
        }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            basicSalary = hoursWorked * ratePerHour;
        }
        public double getSalary()
        {
            return basicSalary;
        }
    }

}
