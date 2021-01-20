using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedulas {
    class Program {
        static void Main(string[] args) {
            int entrada = int.Parse(Console.ReadLine());

            int atual = entrada;

            int notas100 = atual / 100;
            atual -= notas100 * 100;

            int notas50 = atual / 50;
            atual -= notas50 * 50;

            int notas20 = atual / 20;
            atual -= notas20 * 20;

            int notas10 = atual / 10;
            atual -= notas10 * 10;

            int notas5 = atual / 5;
            atual -= notas5 * 5;

            int notas2 = atual / 2;
            atual -= notas2 * 2;

            int notas1 = atual / 1;
            atual -= notas1 * 1;

            Console.WriteLine(entrada);
            Console.WriteLine(notas100 + " Nota(s) de R$100.00");
            Console.WriteLine(notas50 + " Nota(s) de R$50.00");
            Console.WriteLine(notas20 + " Nota(s) de R$20.00");
            Console.WriteLine(notas10 + " Nota(s) de R$10.00");
            Console.WriteLine(notas5 + " Nota(s) de R$5.00");
            Console.WriteLine(notas2 + " Nota(s) de R$2.00");
            Console.WriteLine(notas1 + " Nota(s) de R$1.00");

        }
    }
}
