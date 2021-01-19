using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculoSimples {
    class Program {
        static void Main(string[] args) {
            string[] entrada;

            entrada = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(entrada[0]);
            int pecas1 = int.Parse(entrada[1]);
            double valor1 = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            entrada = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(entrada[0]);
            int pecas2 = int.Parse(entrada[1]);
            double valor2 = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            double resultado = ((pecas1 * valor1) + (pecas2 * valor2));

            Console.WriteLine("VALOR A PAGAR: R$ " + resultado.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
