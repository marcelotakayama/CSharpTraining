using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoDeRenda {
    class Program {
        static void Main(string[] args) {
            string in1 = Console.ReadLine();
            if (in1 == "vertebrado") {
                string in2 = Console.ReadLine();
                if (in2 == "ave") {
                    string in3 = Console.ReadLine();
                    if (in3 == "carnivoro") {
                        Console.WriteLine("aguia");
                    } else {
                        Console.WriteLine("pomba");
                    }
                } else {
                    string in3 = Console.ReadLine();
                    if (in3 == "onivoro") {
                        Console.WriteLine("homem");
                    } else {
                        Console.WriteLine("vaca");
                    }
                }
            } else {
                string in2 = Console.ReadLine();
                if (in2 == "inseto") {
                    string in3 = Console.ReadLine();
                    if (in3 == "hematofago") {
                        Console.WriteLine("pulga");
                    } else {
                        Console.WriteLine("lagarta");
                    }
                } else {
                    string in3 = Console.ReadLine();
                    if (in3 == "hematofago") {
                        Console.WriteLine("sanguessuga");
                    } else {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
