using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto2 {
    class Program {
        static void Main(string[] args) {
            int entrada = int.Parse(Console.ReadLine());

            for(int i=1; i<=10000; i++) {
                if(i % entrada == 2) {
                    Console.WriteLine(i);
                    i++;
                }
            }
        }
    }
}
