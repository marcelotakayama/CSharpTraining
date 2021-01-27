using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoDeNota {
    class Program {
        static void Main(string[] args) {
            while (true) {
                int nota = int.Parse(Console.ReadLine());
                if(nota < 6) {
                    Console.WriteLine("nota invalida");
                } else {
                    Console.WriteLine("nota valida");
                }
            }
        }
    }
}
