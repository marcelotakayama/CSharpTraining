using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasMoedas {
    class Program {
        static void Main(string[] args) {
            double entrada = double.Parse(Console.ReadLine());
            int notas = (int)entrada;
            int moedas = (int)((entrada - notas) * 100);


        }
    }
}
