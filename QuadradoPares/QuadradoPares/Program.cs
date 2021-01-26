using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadradoPares {
    class Program {
        static void Main(string[] args) {
            int entrada = int.Parse(Console.ReadLine());
            int contador = 0;

            if (entrada > 5 && entrada < 2000) {
                for(int i=0; i<entrada; i++) {
                    if (i % 2 == 0) {
                        Console.WriteLine(i + "^ 2 = " + (i*i));
                    }
                }
            }
        }
    }
}
