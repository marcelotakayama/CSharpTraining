using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivosMedia {
    class Program {
        static void Main(string[] args) {
            int positivo = 0;
            double media = 0;

            for(int i = 0; i < 6; i++) {
                double num = double.Parse(Console.ReadLine());
                if (num > 0) {
                    positivo++;
                    media += num;
                }
            }
            media = media / positivo;
            Console.WriteLine(positivo + " valoras positivos");
            Console.WriteLine("Média: " + media);
        }
    }
}
