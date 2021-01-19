using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Salaraio2 {
    class Program {
        static void Main(string[] args) {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double comissao = ((vendas / 100) * 15);
            double resultado = salario + comissao;

            Console.WriteLine("TOTAL = R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
