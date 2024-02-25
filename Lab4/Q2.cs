//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab4
//{
//    class Employee
//    {
//        public int employeeID { get; }
//        public string FullName { get; set; }
//        public double Salary { get; private set; }

//        public Employee(int ID, string name, double salary)
//        {
//            employeeID = ID;
//            FullName = name;
//            Salary = salary;
//        }

//        public void DisplayEmployeeInfo()
//        {
//            Console.WriteLine("Employee ID: " + employeeID);
//            Console.WriteLine("Full Name: " + FullName);
//            Console.WriteLine("Salary: " + Salary);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee employee1 = new Employee(101, "John Doe", 50000);
//            Console.WriteLine("Employee ID: " + employee1.employeeID);
//            employee1.FullName = "Charles Dane";

//            //employee.Salary = 60000;
//            // Observations:
//            // This results in an error because the Salary property is private. This prevents external code from directly modifying the salary.
//            Console.ReadLine();
//        }
//    }
//}
