﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada {
    class Program {
        static void Main(string[] args) {
            int inp = int.Parse(Console.ReadLine());

            for(int i=1; i<=10; i++) {
                Console.WriteLine(i + " X " + i + " = " + (i * inp));
            }
        }
    }
}
