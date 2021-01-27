using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhaFixa {
    class Program {
        static void Main(string[] args) {
            

            while (true) {
                int senha = int.Parse(Console.ReadLine());

                if (senha != 2002) {
                    Console.WriteLine("Senha invalida");
                } else {
                    Console.WriteLine("Acesso permitido");
                    break;
                }
            }
        }
    }
}
