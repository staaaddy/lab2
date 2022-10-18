using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
 
 namespace lab2task4 {
    class Program {
        static void Main(string[] args) {
            var user = new User();
            user.Name = "Anton";
            user.Surname = "Kartoshka";
            user.Login = "Potatto228";
            user.Age = 23;

            foreach (PropertyInfo property in user.GetType().GetProperties()) {
                Console.WriteLine(property.Name + " : " + property.GetValue(user, null));
            }
            Console.ReadLine();
        }
    }
 }