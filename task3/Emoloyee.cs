using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task3 {
    public class Employee {
        public Employee(string name, string surname) {
            Name = name;
            Surname = surname;
            Random random = new Random();
            Experience = random.Next(0, 25);
            Role = (Role)random.Next(0, 3);
            if (Experience > 10) {
                Salary = Salary + 3000;
            }
            if (Role == (Role)2) {
                Salary = Salary + 4000;
            }
        }
public string Name;
public string Surname;
public int Experience; 
public int Salary = 8000;
public int Duty;

public Role Role {get; set; }
public int salary {get {return Salary;}}

public int duty {
    get {
        if (Salary >- 12000) {
        Duty = Salary / 12;
    }
    else
    {
        Duty = salary / 9;
    }
    return Duty;
}

    }

    
}
}