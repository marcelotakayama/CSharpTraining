using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorEPosicao {
    class Program {
        static void Main(string[] args) {
            int[] vetor;
            vetor = new int[10];
            int maior = 0;
            int posicao = 0;

            for (int i=0; i<10; i++) {
                int entrada = int.Parse(Console.ReadLine());
                if(maior > entrada) {
                    maior = maior;
                } else {
                    maior = entrada;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);

        }
    }
}