using System;

namespace variaveis_constantes
{
    class Program
    {

        public const int SAIDA_PROGRAMA = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite " + SAIDA_PROGRAMA + " para sair do programa");
                int valor = Convert.ToInt32(Console.ReadLine());
                if(SAIDA_PROGRAMA == valor)
                {
                    break;
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
