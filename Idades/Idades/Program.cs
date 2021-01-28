using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idades {
    class Program {
        static void Main(string[] args) {
            int total = 0;
            int qtd = 0;
            while (true) {
                int entrada = int.Parse(Console.ReadLine());
                if (entrada < 0) {
                    break;
                } else {
                    total += entrada;
                    qtd++;
                }
            }
            Console.WriteLine(total/qtd);
        }
    }
}
