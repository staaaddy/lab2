using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace lab2task4 {
    class User {
        public User() {
            DateSub = DateTime.UtcNow;
        }
        public string Login {get; set;}
        public string Name {get; set;}
        public string Surname {get; set;}
        public int Age {get; set;}

        public DateTime DateSub {get;}
        
    }
}