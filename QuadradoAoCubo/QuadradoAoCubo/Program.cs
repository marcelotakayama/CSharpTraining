using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadradoAoCubo {
    class Program {
        static void Main(string[] args) {
            int entrada = int.Parse(Console.ReadLine());

            for(int i=1; i<=entrada; i++) {
                Console.WriteLine(i + " " + (Math.Pow(i, 2)) + " " + (Math.Pow(i, 3)));
            }
        }
    }
}
