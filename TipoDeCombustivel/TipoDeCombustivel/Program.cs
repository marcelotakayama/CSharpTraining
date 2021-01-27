using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDeCombustivel {
    class Program {
        static void Main(string[] args) {

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            for (int i=0; i<5; i++) {
                int entrada = int.Parse(Console.ReadLine());

                switch (entrada) {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
