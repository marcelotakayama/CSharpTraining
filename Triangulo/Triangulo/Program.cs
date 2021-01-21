using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo {
    class Program {
        static void Main(string[] args) {
            string[] entrada = Console.ReadLine().Split(' ');

            double a = double.Parse(entrada[0]);
            double b = double.Parse(entrada[1]);
            double c = double.Parse(entrada[2]);

            if(a + b > c || b + c > a || a + c > b) {
                Console.WriteLine("Perimetro = " + (a + b + c));
            } else {
                Console.WriteLine("Area = " + (a + b) / 2);
            }
        }
    }
}
