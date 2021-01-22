using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParesImparesPositivosNegativos {
    class Program {
        static void Main(string[] args) {
            int par = 0;
            int impar = 0;
            int positivo = 0;
            int negativo = 0;
            for(int i=0; i<5; i++) {
                int entrada = int.Parse(Console.ReadLine());
                if(entrada % 2 == 0) {
                    par++;
                } else if (entrada % 2 != 0) {
                    impar++;
                } else if (entrada > 0) {
                    positivo++;
                } else if(entrada < 0) {
                    negativo++;
                }
            }
            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");
        }
    }
}
