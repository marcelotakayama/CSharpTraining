using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Bhaskara {
    class Program {
        static void Main(string[] args) {
            string[] entrada = Console.ReadLine().Split(' ');
            double a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            double c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            double x1 = ((b*-1.0) + Math.Sqrt((b*b)-4 * a * c)) / (2 * a);
            double x2 = ((b*-1.0) - Math.Sqrt((b*b)-4 * a * c)) / (2 * a);

            if(a==0 || b==0 || c == 0) {
                Console.WriteLine("Impossível calcular");
            } else {
                Console.WriteLine("R1" + x1.ToString("0.00000"));
                Console.WriteLine("R2" + x2.ToString("0.00000"));
            }

        }
    }
}
