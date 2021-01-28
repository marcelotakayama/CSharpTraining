using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaLogica {
    class Program {
        static void Main(string[] args) {
            int cont = 0;
            int entrada = int.Parse(Console.ReadLine());
            for(int i=0; i<= (entrada*2); i++) {
                Console.WriteLine(i + 2);
            }
        }
    }
}
