using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanche {
    class Program {
        static void Main(string[] args) {
            string[] pedido = Console.ReadLine().Split(' ');
            int cod = int.Parse(pedido[0]);
            int qtd = int.Parse(pedido[1]);

            switch (cod) {
                case 1:
                    Console.WriteLine("Total: R$ " + (qtd * 4));
                    break;
                case 2:
                    Console.WriteLine("Total: R$ " + (qtd * 4.50));
                    break;
                case 3:
                    Console.WriteLine("Total: R$ " + (qtd * 5));
                    break;
                case 4:
                    Console.WriteLine("Total: R$ " + (qtd * 2));
                    break;
                case 5:
                    Console.WriteLine("Total: R$ " + (qtd * 1.50));
                    break;

            }
        }
    }
}
