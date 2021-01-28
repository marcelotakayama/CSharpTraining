using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividindoXporY {
    class Program {
        static void Main(string[] args) {
            int qtd = int.Parse(Console.ReadLine());
            for(int i=0; i<qtd; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                int n1 = int.Parse(vet[0]);
                int n2 = int.Parse(vet[1]);

                if(n1 == 0 || n2 == 0) {
                    Console.WriteLine("Divisão impossivel");
                } else {
                    Console.WriteLine(n1/n2);
                }
            }
        }
    }
}
