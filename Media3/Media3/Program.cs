using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Media3 {
    class Program {
        static void Main(string[] args) {
            string[] notas = Console.ReadLine().Split(' ');
            double n1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            double n4 = double.Parse(notas[3], CultureInfo.InvariantCulture);

            double media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + n4)/10;

            Console.WriteLine("Media: " + media, CultureInfo.InvariantCulture);

            if (media >= 7.0) {
                Console.WriteLine("Aluno aprovado.");
            } else if (media < 5.0) {
                Console.WriteLine("Aluno reprovado.");
            } else if(media >= 5.0 && media < 7.0) {
                Console.WriteLine("Aluno em exame:");
                double exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exame,  CultureInfo.InvariantCulture);
                double notaFinal = (media + exame) / 2;
                
                if(notaFinal >= 5.0) {
                    Console.WriteLine("Aluno aprovado.");
                } else if(notaFinal < 5.0) {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: "+ notaFinal, CultureInfo.InvariantCulture);

            }
        }
    }
}
