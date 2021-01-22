using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaImparesConsecutivos {
    class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int impar = 0;
            for(int i=0; i<b; i++) {
                if(i%2 != 0) {
                    impar++;
                }
            }//a
            Console.WriteLine(impar);
        }
    }
}