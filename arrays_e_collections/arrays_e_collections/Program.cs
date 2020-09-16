using System;
using System.Collections.Generic;

namespace arrays_e_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============Arrays===================");
            string[] a = new string[3];
            var aa = new string[3];
            a[0] = "Bruno";
            a[1] = "Márcia";
            a[2] = "Dereck";
            Array.Sort(a);
            
            foreach (string nome in a) {
                Console.WriteLine(nome);
            }

            if(Array.Exists(a, e => e == "Márcia"))
            {
                Console.WriteLine("Achei a Márcia");
            }

            Console.WriteLine("==========Collection================");
            List<string> b = new List<string>();
            var bb = new List<string>();
            b.Add("Bruno");
            b.Add("Márcia");
            b.Add("Dereck");
            b.Sort();

            foreach (string nome in b)
            {
                Console.WriteLine(nome);
            }

            if (b.Exists(e => e == "Bruno"))
            {
                Console.WriteLine("Encontrei o Bruno");
            }

            Console.Read();
        }
    }
}
