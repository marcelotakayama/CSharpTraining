using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MaiorNumero {
    class Program {
        static void Main(string[] args) {
            string[] entrada = Console.ReadLine().Split(' ');
            int a = int.Parse(entrada[0], CultureInfo.InvariantCulture);
            int b = int.Parse(entrada[1], CultureInfo.InvariantCulture);
            int c = int.Parse(entrada[2], CultureInfo.InvariantCulture);

            if(a > b && a > c) {
                Console.WriteLine(a + " eh o maior");
            } else if (b > a && b > c) {
                Console.WriteLine(b + " eh o maior");
            } else {
                Console.WriteLine(c + " eh o maior");
            }
        }
    }
}
