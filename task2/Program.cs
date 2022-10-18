using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task2 {
    class Program {
        static void Main(string[] args) {
            Converter converter = new Converter(40.30, 38.60, 0.30);
Console.WriteLine("Введіть кількість UAH");
converter.ConverFromUAH(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введіть кількість іншої валюти");
converter.ConverterToUAH(Convert.ToInt32(Console.ReadLine()));
Console.ReadKey();
        }
    }
}
