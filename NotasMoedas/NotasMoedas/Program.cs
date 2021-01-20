using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasMoedas {
    class Program {
        static void Main(string[] args) {
            double dinheiro = double.Parse(Console.ReadLine());
            double[] valor = { 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            int quantidadeNotas;
            
            Console.WriteLine("NOTAS:");
            for(int i=0; i<6; i++) {
                quantidadeNotas = (int)(dinheiro / valor[i]);
                Console.WriteLine(quantidadeNotas + " nota(s) de R$ " + valor[i].ToString("0.00"));
                dinheiro -= quantidadeNotas * valor[i];
                dinheiro = Math.Round(dinheiro, 2);
            }
            
            Console.WriteLine("MOEDAS:");
            for(int i=6; i<valor.Length; i++) {
                quantidadeNotas = (int)(dinheiro / valor[i]);
                Console.WriteLine(quantidadeNotas + " moeda(s) de R$ " + valor[i].ToString("0.00"));
                dinheiro -= quantidadeNotas * valor[i];
                dinheiro = Math.Round(dinheiro, 2);
            }
        }
    }
}
