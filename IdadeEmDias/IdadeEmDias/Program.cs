using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeEmDias {
    class Program {
        static void Main(string[] args) {
            int entrada = int.Parse(Console.ReadLine());

            int ano = entrada / 365;
            entrada -= ano * 365;

            int mes = entrada / 30;
            entrada -= mes * 30;

            int dias = entrada;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
