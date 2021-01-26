using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadradoPares {
    class Program {
        static void Main(string[] args) {
            int entrada = int.Parse(Console.ReadLine());

            if (entrada > 5 && entrada < 2000) {
                for(int i=0; i<=entrada; i++) {
                    if (i > 0) {
                        if (i % 2 == 0) {
                            Console.WriteLine(i + "^ 2 = " + (Math.Pow(i, 2)));
                            i++;
                        }
                    }
                }
            }
        }
    }
}
