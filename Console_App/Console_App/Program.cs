using System;
using System.Collections.Generic;
using System.IO;

namespace Console_App
{
    class Program
    {

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        private static void CalcularMediaAluno()
        {
            Console.WriteLine("Digite o nome do aluno");
            string nome = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("Digite as " + qtdNotas + " nota do aluno");

            List<int> notas = new List<int>();
            int totalNotas = 0;
            for(int i = 1; i<= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota número " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }

            int media = totalNotas / notas.Count;
            Console.WriteLine("A média do aluno " + nome + " é: " + media);
            Console.WriteLine("Suas notas são: \n");
            foreach(int nota in notas)
            {
                Console.WriteLine("Nota: " + nota + "\n");
            }
        }

        private static void Menu()
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
                    LerArquivos(1);
                    Console.WriteLine("==================================================================");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("======================Opção Tabuada==========================");
                    Console.WriteLine("Digite o número que deseja na tabuada");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());
                    Tabuada(numeroTabuada);
                    Console.WriteLine("=============================================================");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("======================Opção Cálculo Média==========================");
                    CalcularMediaAluno();
                    Console.WriteLine("===================================================================");
                }
                else
                {
                    Console.WriteLine("Opção inválida, digite novamente!");
                }

            }
        }

        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("Olá Pessoal");
        }

        public static void Tabuada(int numero)
        {
            Console.WriteLine("++++++++++++Cálculo da Tabuada do " + numero + "+++++++++++++++++++");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
            Console.WriteLine("++++++++++++++++++++++++++++++");
        }

        private static void LerArquivos(int numeroArquivo)
        {
            string caminhoRelativo = @"E:\Programação\Github\CursoTorneseUmProgramador\funcoes_recursivas\funcoes_recursivas\arquivos\arq" + numeroArquivo + ".txt";
            Console.WriteLine("========== Lendo Arquivo ==========\n" + caminhoRelativo);
            if (File.Exists(caminhoRelativo))
            {
                using (StreamReader arquivo = File.OpenText(caminhoRelativo))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string caminhoRelativo2 = @"E:\Programação\Github\CursoTorneseUmProgramador\funcoes_recursivas\funcoes_recursivas\arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(caminhoRelativo))
            {
                LerArquivos(numeroArquivo + 1);
            }
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
