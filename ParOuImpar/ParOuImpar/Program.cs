using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar {
    class Program {
        static void Main(string[] args) {
            int qtd = int.Parse(Console.ReadLine());
            int saida = 0;
            for (int i = 1; i <= qtd; i++) {
                int entrada = int.Parse(Console.ReadLine());
                
                if (entrada == 0) {
                    Console.WriteLine("NULL");
                } else if (entrada > 0 && entrada % 2 == 0) {
                    Console.WriteLine("EVEN POSITIVE");
                } else if (entrada < 0 && entrada % 2 == 0) {
                    Console.WriteLine("EVEN NEGATIVE");
                } else if (entrada > 0 && entrada % 2 != 0) {
                    Console.WriteLine("ODD POSITIVE");
                } else if (entrada < 0 && entrada % 2 != 0) {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
        }
    }
}
