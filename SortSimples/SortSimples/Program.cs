using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSimples {
    class Program {
        static void Main(string[] args) {
            string[] arr = Console.ReadLine().Split(' ');

            int n1 = int.Parse(arr[0]);
            int n2 = int.Parse(arr[1]);
            int n3 = int.Parse(arr[2]);

            int menor;
            int meio;
            int maior;

            if(n1 < n2 && n1 < n3) {
                menor = n1;
                if (n2 < n3) {
                    meio = n2;
                    maior = n3;
                } else {
                    meio = n3;
                    maior = n2;
                }
            } else if (n2 < n1 && n2 < n3) {
                menor = n2;
                if (n1 < n3) {
                    meio = n1;
                    maior = n3;
                } else {
                    meio = n3;
                    maior = n1;
                }
            } else if (n3 < n1 && n3 < n2) {
                menor = n3;
                if (n1 < n3) {
                    meio = n1;
                    maior = n2;
                } else {
                    meio = n2;
                    maior = n1;
                }
                //teste
            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);
            }
        }
    }
}
