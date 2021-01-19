using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GastoCombustivel {
    class Program {
        static void Main(string[] args) {
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            double result = (tempo * velocidade) / 12;
            //teste2
            Console.WriteLine(result.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
