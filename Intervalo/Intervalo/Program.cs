using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Intervalo {
    class Program {
        static void Main(string[] args) {
            double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (entrada > 0 && entrada <= 25.00) {
                Console.WriteLine("Intervalo [0, 25]");
            } else if (entrada > 25.0 && entrada <= 50.0) {
                Console.WriteLine("Intervalo [25, 50]");
            } else if (entrada > 50.0 && entrada <= 75.0) {
                Console.WriteLine("Intervalo [50, 75]");
            } else if (entrada > 75.0 && entrada <= 100.0) {
                Console.WriteLine("Intervalo [75, 100]");
            } else {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
