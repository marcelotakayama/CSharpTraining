using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Consumo {
    class Program {
        static void Main(string[] args) {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = X / Y;

            Console.WriteLine(result.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
