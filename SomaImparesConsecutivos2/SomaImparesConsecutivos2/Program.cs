using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaImparesConsecutivos2 {
    class Program {
        static void Main(string[] args) {
            int qtd = int.Parse(Console.ReadLine());
            int maior = 0;
            int menor = 0;
            int impares = 0;

            for(int i=0; i<qtd; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                int a = int.Parse(vet[0]);
                int b = int.Parse(vet[1]);

                if(a > b) {
                    maior = a;
                    menor = b;
                } else {
                    menor = a;
                    maior = b;
                }

                for(int j=menor; j<maior; j++) {
                    if(j % 2 != 0) {
                        impares += j;
                    }
                }
                Console.WriteLine(impares);
                impares = 0;
            }
        }
    }
}
