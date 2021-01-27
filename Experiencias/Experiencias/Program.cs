using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiencias {
    class Program {
        static void Main(string[] args) {
            int qtd = int.Parse(Console.ReadLine());
            int ratos = 0;
            int sapos = 0;
            int coelhos = 0;
            int total = 0;

            int pcoelho = (total / 100);// * coelhos;
            int prato = (total / 100) * ratos;
            int psapo = (total / 100) * sapos;

            for (int i=0; i<qtd; i++) {
                string[] dados = Console.ReadLine().Split(' ');
                int in1 = int.Parse(dados[0]);
                string in2 = (dados[1]);

                total += in1;
                if(in2 == "R") {
                    ratos += in1;
                } else if(in2 == "C") {
                    coelhos += in1;
                } else if (in2 == "S") {
                    sapos += in1;
                }
            }
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);

            Console.WriteLine("Percentual de coelhos: " + pcoelho);
            Console.WriteLine("Percentual de ratos: " + prato);
            Console.WriteLine("Percentual de sapos: " + psapo);
        }
    }
}
