using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempoDeJogo {
    class Program {
        static void Main(string[] args) {
            string[] entrada = Console.ReadLine().Split(' ');

            int a = int.Parse(entrada[0]);
            int b = int.Parse(entrada[1]);

            if (a > b) {
                Console.WriteLine("O JOGO DUROU " +  (24 - a + b) + " HORA(S)");
            } else if (a < b) {
                Console.WriteLine("O JOGO DUROU " + (b - a) + " HORA(S)");
            } else {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
        }
    }
}
