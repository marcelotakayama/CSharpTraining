﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos {
    class Program {
        static void Main(string[] args) {
            string[] entrada = Console.ReadLine().Split(' ');

            int a = int.Parse(entrada[0]);
            int b = int.Parse(entrada[1]);

            if(a % b == 0 || b % a == 0) {
                Console.WriteLine("Sao Multiplos");
            } else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
