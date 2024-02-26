using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial03q2
{


    class Employee
    {
        private int employeeID;
        private string fullName;
        private double salary;

        public int EmployeeID
        {
            get { return employeeID; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public double Salary
        {
            get { return salary; }
        }

        // Constructor
        public Employee(int employeeID, string fullName, double salary)
        {
            this.employeeID = employeeID;
            this.FullName = fullName;
            this.salary = salary;
        }

        // Display Employee Information
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }

    class Program
    {
        static void Main()
        {
            // a) Create an instance of the "Employee" class
            Employee johnDoe = new Employee(101, "John Doe", 50000);

            // b) Access and display the employee ID using the read-only property
            Console.WriteLine($"Employee ID: {johnDoe.EmployeeID}");

            // c) Update the full name of the employee using the read-write property
            johnDoe.FullName = "Jane Doe";

            // d) Attempt to modify the salary directly from external code
            // This will result in a compilation error since Salary has only a get accessor
            // johnDoe.Salary = 55000; // Uncommenting this line will result in a compilation error

            // Display updated employee information
            johnDoe.DisplayEmployeeInfo();
        }
    }
}