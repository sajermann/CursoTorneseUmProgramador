using System;
using System.Collections.Generic;
using System.Text;
using Calculo;
using Diretorio;
using Funcoes;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public static void Criar()
        {
            while (true)
            {
                string mensagem = " Olá Usuário, bem vindo ao programa\n" +
                    "\n  Utilizando programação funcional" +
                    "\n\n" +
                    "\n   Digite uma das opções abaixo:" +
                    "\n     0 - Sair do programa" +
                    "\n     1 - Para Ler arquivos" +
                    "\n     2 - Para Executar a tabuada" +
                    "\n     3 - Para Cálcular média de alunos";
                Console.WriteLine(mensagem);

                int valor = Convert.ToInt32(Console.ReadLine());


                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("======================Opção Ler Arquivos==========================");
                    Arquivo.Ler(1);
                    Console.WriteLine("==================================================================");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("======================Opção Tabuada==========================");
                    Console.WriteLine("Digite o número que deseja na tabuada");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());
                    Tabuada.Calcular(numeroTabuada);
                    Console.WriteLine("=============================================================");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("======================Opção Cálculo Média==========================");
                    Media.Aluno();
                    Console.WriteLine("===================================================================");
                }
                else
                {
                    Console.WriteLine("Opção inválida, digite novamente!");
                }

            }
        }

    }
}
