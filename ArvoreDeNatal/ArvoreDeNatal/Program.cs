using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreDeNatal {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int t = n / 2;

            while(i <= n) {
                for(int j=0; j<t; j++) {
                    Console.WriteLine(" ");
                }
                for(int j=0; j<i; j++) {
                    Console.WriteLine("*");
                }

                i += 2;
                t--;
                Console.WriteLine("\n");
            }
            i = 1;
            t = n / 2;

            while(i <= 3) {
                for(int j=0; j<t; j++) {
                    Console.WriteLine(" ");
                }
                for(int j=0; j<i; j++) {
                    Console.WriteLine("*");
                }
                i += 2;
                t--;
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
    }
}
