using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaNumerosSoma {
    class Program {
        static void Main(string[] args) {
            while (true) {
                int maior = 0;
                int menor = 0;

                string[] vet = Console.ReadLine().Split(' ');
                int m = int.Parse(vet[0]);
                int n = int.Parse(vet[1]);

                if (m == 0 || n == 0) {
                    break;
                }
                if(m >= n) {
                    maior = m;
                    menor = n;
                }
                else if (m <= n) {
                    maior = n;
                    menor = m;
                }
                int soma = 0;
                for(int c = menor; c <= maior; c++) {
                    Console.WriteLine("{0}", c);
                    soma += c;
                }
                Console.WriteLine("soma = " + soma);
                Console.WriteLine();
            }
        }
    }
}
