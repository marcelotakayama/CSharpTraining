using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosImpares {
    class Program {
        static void Main(string[] args) {
            int entrada = int.Parse(Console.ReadLine());
            int cont = 0;
            for(int i=0; i<entrada; i++) {
                if(i % 2 != 0) {
                    //d
                    Console.WriteLine(i);
                    cont++;
                }
            }
        }
    }
}
