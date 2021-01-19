using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Media1 {
    class Program {
        static void Main(string[] args) {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a + b) / 2; 

            Console.WriteLine("MEDIA=" + media.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
