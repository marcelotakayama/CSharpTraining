using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Esfera {
    class Program {
        static void Main(string[] args) {
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = (4 / 3.0) * pi * (raio * raio * raio);

            Console.WriteLine("VOLUME = " + resultado.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
