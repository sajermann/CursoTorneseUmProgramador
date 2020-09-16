using System;
using System.Security.Cryptography.X509Certificates;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================While========================");
            int a = 1;
            while(a < 3)
            {
                Console.WriteLine(a);
                a++;
            }

            int b = 1;
            while (b <= 10)
            {
                if(b == 1)
                {
                    b++;
                    continue;
                }
                if (b == 8)
                {
                    break;
                }
                Console.WriteLine(b);
                b++;
            }

            Console.WriteLine("==================Do While======================");
            int c = 1;
            do
            {
                Console.WriteLine(c);
                c++;
            } while (c < 3);

            int d = 1;
            do
            {
                if (d == 1)
                {
                    d++;
                    continue;
                }
                if (d == 8)
                {
                    break;
                }
                Console.WriteLine(d);
                d++;
            } while (d <= 10);

            Console.WriteLine("==================For======================");
            for(int e = 1; e <= 3; e++)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("==================Foreach===================");
            int[] f = { 1, 2, 3 };
            foreach(int v in f)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("==============Função Recursiva==============");
            looping(1);
        }

        public static void looping(int a)
        {
            Console.WriteLine(a);
            if(a < 3)
            {
                looping(a + 1);
            }

        }
    }
}
