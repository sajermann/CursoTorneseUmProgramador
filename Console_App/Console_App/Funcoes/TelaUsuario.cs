using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funcoes
{
    class TelaUsuario
    {
        public static void Chamar()
        {
            //Console.WriteLine("=================Cadastro de Usuario=================");
            while (true)
            {

                string mensagem = "Digite uma das opções abaixo:" +
                "\n     0 - Sair do cadastro" +
                "\n     1 - Para cadastrar Usuarios" +
                "\n     2 - Para listar Usuarios";

                Console.WriteLine(mensagem);


                int valor = Convert.ToInt32(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if(valor == 1)
                {
                    var usuario = new Usuario();
                    Console.WriteLine("Digite o Nome do Usuario:");
                    usuario.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o Telefone do Usuario:");
                    usuario.Telefone = Console.ReadLine();
                    Console.WriteLine("Digite o CPF do Usuario:");
                    usuario.Cpf = Console.ReadLine();
                    usuario.Gravar();
                }
                else
                {
                    var Usuarios = new Usuario().Ler();
                    foreach (Usuario c in Usuarios)
                    {
                        Console.WriteLine("===============================");
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("Cpf: " + c.Cpf);
                        Console.WriteLine("===============================");
                    }

                }

            }
        }

    }
}
