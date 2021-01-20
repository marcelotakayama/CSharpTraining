using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordenadasDeUmPonto {
    class Program {
        static void Main(string[] args) {
            string[] entrada = Console.ReadLine().Split(' ');
            double c1 = double.Parse(entrada[0]); 
            double c2 = double.Parse(entrada[1]);

            if (c1 == 0 && c2 == 0) {
                Console.WriteLine("Origem");
            } else if (c1 == 0) {
                Console.WriteLine("Eixo X");
            } else if (c2 == 0) {
                Console.WriteLine("Eixo Y");
            } else if (c1 > 0 && c2 > 0) {
                Console.WriteLine("Q1");
            } else if (c1 < 0 && c2 > 0) {
                Console.WriteLine("Q2");
            } else if (c1 < 0 && c2 < 0) {
                Console.WriteLine("Q3");
            } else if (c1 > 0 && c2 < 0) {
                Console.WriteLine("Q4");
            }
        }
    }
}
