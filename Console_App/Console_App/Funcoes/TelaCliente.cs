﻿using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funcoes
{
    class TelaCliente
    {
        public static void Chamar()
        {
            //Console.WriteLine("=================Cadastro de Cliente=================");
            while (true)
            {

                string mensagem = "Digite uma das opções abaixo:" +
                "\n     0 - Sair do cadastro" +
                "\n     1 - Para cadastrar clientes" +
                "\n     2 - Para listar clientes";

                Console.WriteLine(mensagem);


                int valor = Convert.ToInt32(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if(valor == 1)
                {
                    var cliente = new Cliente();
                    Console.WriteLine("Digite o Nome do Cliente:");
                    cliente.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o Telefone do Cliente:");
                    cliente.Telefone = Console.ReadLine();
                    Console.WriteLine("Digite o CPF do Cliente:");
                    cliente.Cpf = Console.ReadLine();
                    cliente.Gravar();
                }
                else
                {
                    var clientes = new Cliente().Ler();
                    foreach (Cliente c in clientes)
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
