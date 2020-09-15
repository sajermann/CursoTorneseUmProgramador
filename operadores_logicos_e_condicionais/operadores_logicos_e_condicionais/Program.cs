using System;

namespace operadores_logicos_e_condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 2;

            if (a == 1)
            {
                Console.WriteLine("Entrou na condição do if");
                Console.WriteLine("==============");
            }
            else if(a == 2)
            {
                Console.WriteLine("Caiu no bloco do senão se a = 2");
                Console.WriteLine("==============");
            }
            else
            {
                Console.WriteLine("Caiu no bloco do Else");
                Console.WriteLine("==============");
            }

            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            string nome= "Br5uno";
            string teste = (nome == "Bruno" ? " Sajermann" : " Desconhecido");

            Console.WriteLine("Olá Pessoa! " + teste);
            Console.WriteLine("==============");



            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
