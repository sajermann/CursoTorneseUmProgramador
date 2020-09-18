using System;
using System.Collections.Generic;
using System.Text;

namespace Funcoes
{
    class Tabuada
    {
        public static void Calcular(int numero)
        {
            Console.WriteLine("++++++++++++Cálculo da Tabuada do " + numero + "+++++++++++++++++++");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
            Console.WriteLine("++++++++++++++++++++++++++++++");
        }

    }
}
