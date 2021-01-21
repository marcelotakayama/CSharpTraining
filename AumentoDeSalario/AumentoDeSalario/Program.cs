using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AumentoDeSalario {
    class Program {
        static void Main(string[] args) {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int reajuste = 0;
            
            if(salario > 0 && salario <= 400) {
                reajuste = 15;
            } else if (salario > 400 && salario <= 800) {
                reajuste = 12;
            } else if(salario > 800 && salario <= 1200) {
                reajuste = 10;
            } else if (salario > 1200 && salario <= 2000) {
                reajuste = 7;
            } else {
                reajuste = 4;
            }

            double nReajuste = (salario / 100) * reajuste;
            double nSalario = salario + nReajuste;

            Console.WriteLine("Novo salario: " + nSalario, CultureInfo.InvariantCulture);
            Console.WriteLine("Reajuste ganho: " + nReajuste, CultureInfo.InvariantCulture);
            Console.WriteLine("Em percentual: " + reajuste, CultureInfo.InvariantCulture);
        }
    }
}
