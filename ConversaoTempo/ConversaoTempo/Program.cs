using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTempo {
    class Program {
        static void Main(string[] args) {
            int entrada = int.Parse(Console.ReadLine());

            int h = entrada / 3600;
            entrada -= h * 3600;

            int m = entrada / 60;
            entrada -= m * 60;

            int s = entrada;

            Console.WriteLine(h + ":" + m + ":" + s);
        }
    }
}
