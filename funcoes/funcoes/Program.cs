using System;

namespace funcoes
{
    class Program
    {
        static int Calcular()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }

        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("Olá Pessoal");
        }

        public static void Tabuada(int numero)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++");
            for(int i = 0; i<= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
            Console.WriteLine("++++++++++++++++++++++++++++++");
        }
        static void Main(string[] args)
        {
            int retorno = Calcular();
            Console.WriteLine(retorno);
            MostrarMensagemNaTela();
            Tabuada(9);
            Tabuada(98);
            Console.Read();
        }
    }
}
