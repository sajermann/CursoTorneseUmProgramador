using System;

namespace tipos_de_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            //i = "s";
            
            var x = 2;
            //x = "333";

            char t = 'B';
            string t2 = "B";

            string s = "Bruno Sajermann";
            var s2 = "Marcia Sajermann";

            var f = 1.5;
            float f2 = 1.5f;

            var d = 1.5;
            double d2 = 1.5;

            var bo = true;
            var bo2 = false;

            bool bol = true;
            bool bol2 = false;

            bool boolean = bool.Parse("false");
            bool boolean2 = Convert.ToBoolean("false");

            //int.Parse();
            //double.Parse();
            //d.ToString();
            //Convert.ToString();

            Animal a = new Animal();
            Leao l = new Leao();

            //l = (Leao)a;

            //a = l;

            Console.WriteLine("Hello World!");
            Console.WriteLine(i);
            Console.WriteLine(x);
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(f);
            Console.WriteLine(f2);
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(t);
            Console.WriteLine(t2);
            Console.WriteLine(bo);
            Console.WriteLine(bo2);
            Console.WriteLine(bol);
            Console.WriteLine(bol2);
        }
    }

    public class Animal
    {

    }
    public class Leao: Animal
    {

    }
}
