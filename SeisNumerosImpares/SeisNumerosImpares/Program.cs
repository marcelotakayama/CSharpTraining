using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeisNumerosImpares {
    class Program {
        static void Main(string[] args) {
            int entrada = int.Parse(Console.ReadLine());
            int impar = 0;

            while (impar < 6) {
                if (entrada % 2 != 0) {
                    Console.WriteLine(entrada);
                    impar++;
                } entrada++;
            }
        }
    }
}
