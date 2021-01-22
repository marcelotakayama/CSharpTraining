using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParesEntreCinco {
    class Program {
        static void Main(string[] args) {
            int pares = 0;

            for (int i = 0; i < 5; i++) {
                int entrada = int.Parse(Console.ReadLine());
                if (entrada % 2 == 0) {
                    pares++;
                }
            }
            Console.WriteLine(pares + " valores pares");
        }
    }
}
