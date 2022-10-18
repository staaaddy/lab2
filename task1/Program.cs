using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace lab2task1 {
   internal class Program {
        static void Main(string[] args) {
            if (true) {
                Console.WriteLine( );
            } else if (false){
                Console.WriteLine();
            }

Address address1 = new Address();
Address address = new Address();
address.Index = 21324;
address.Country = "test";
address.City = "test";
address.Street = "test";
address.House = "test";
address.Apartament = "test";
Console.WriteLine(address1.ToString());
Console.RedLine();

foreach (PropertyInfo property in address1.GetType().GetProperties()) 
            { 
                Console.WriteLine(property.Name + " : " + property.GetValue(address1, null)); 
            } 
 
            foreach (PropertyInfo property in address.GetType().GetProperties()) 
            { 
                property.SetValue(address1, property.GetValue(address), null); 
            } 
 
            foreach (PropertyInfo property in address1.GetType().GetProperties()) 
            { 
                Console.WriteLine(property.Name + " : " + property.GetValue(address1, null)); 
            } 
 
            Console.ReadLine();

        }
    }
}