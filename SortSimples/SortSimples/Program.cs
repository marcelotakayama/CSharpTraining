using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSimples {
    class Program {
        static void Main(string[] args) {
            string[] s = Console.ReadLine().Split(' ');

            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);

            if (a < b && a < c && b < c) {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            } else if (a < b && a < c && b > c) {
                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine(b);
            } else if (a > b && b < c && a < c) {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
            } else if (a > b && b < c && a > c) {
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
            } else if (a < b && b > c && a > c) {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
            } else if (a > b && b > c && a > c) {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
            } else {
            }
            Console.WriteLine("  ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
