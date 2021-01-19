using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DistanciaEntreDoisPontos {
    class Program {
        static void Main(string[] args) {
            string[] entrada;
            entrada = Console.ReadLine().Split(' ');

            double x1 = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(entrada[1], CultureInfo.InvariantCulture);

            entrada = Console.ReadLine().Split(' ');

            double x2 = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(entrada[1], CultureInfo.InvariantCulture);

            double result = Math.Sqrt((x2-x1) * (x2-x1) + (y2 - y1) * (y2 - y1));

            Console.WriteLine(result.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
