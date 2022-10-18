using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task3 {
    class Program {
        static void Main(string[] args) {
            Employee employee = new Employee("Will", "Naggets");
            Console.WriteLine($"{employee.Name} {employee.Surname} {employee.Role} {employee.duty} {employee.Salary}");
            Console.ReadLine();
        }
    }
}