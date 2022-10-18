using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task2 {
    public class Converter {
        public Converter(double usd, double eur, double rub) {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }

        private double Usd;
        private double Eur;
        private double Rub;
         private void Check(string message, bool fork, int value) {
                Console.WriteLine("Яку валюту Ви бажаєте " + message + " usd/eur/rub");
                string choise = Console.ReadLine().ToLower();
                switch(choise) {
                    case "usd":
                    if (fork){
Console.WriteLine($"Ваш результат з USD до UAH = {Usd * value}");
break;
                    }
                    Console.WriteLine($"Ваш результат з UAH до USD = {value / Usd}");
                    break;

                      case "eur":
                    if (fork){
Console.WriteLine($"Ваш результат з EUR до UAH = {Eur * value}");
break;
                    }
                    Console.WriteLine($"Ваш результат з UAH до EUR = {value / Eur}");
                    break;

                      case "rub":
                    if (fork){
Console.WriteLine($"Ваш результат з RUB до UAH = {Rub * value}");
break;
                    }
                    Console.WriteLine($"Ваш результат з UAH до RUB = {value / Rub}");
                    break;

                    default:
                    throw new Exception("Неправильна валюта!");
                }
            }
            public void ConverterToUAH(int clienCurr){
                Check("обміняти", true, clienCurr);
            }

            public void ConverFromUAH(int clienCurr) {
                Check("отримано", false, clienCurr);
            }

    }
}
