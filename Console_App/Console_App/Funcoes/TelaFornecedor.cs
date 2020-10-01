using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funcoes
{
    class TelaFornecedor
    {
        public static void Chamar()
        {
            //Console.WriteLine("=================Cadastro de Fornecedor=================");
            while (true)
            {

                string mensagem = "Digite uma das opções abaixo:" +
                "\n     0 - Sair do cadastro" +
                "\n     1 - Para cadastrar Fornecedores" +
                "\n     2 - Para listar Fornecedores";

                Console.WriteLine(mensagem);


                int valor = Convert.ToInt32(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if(valor == 1)
                {
                    var fornecedor = new Fornecedor();
                    Console.WriteLine("Digite o CNPJ:");
                    fornecedor.Cnpj = Console.ReadLine();
                    Console.WriteLine("Digite o Nome do Fornecedor:");
                    fornecedor.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o Telefone do Fornecedor:");
                    fornecedor.Telefone = Console.ReadLine();
                    Console.WriteLine("Digite o CPF do Gerente:");
                    fornecedor.Cpf = Console.ReadLine();
                    fornecedor.Gravar();
                }
                else
                {
                    var fornecedores = new Fornecedor().Ler();
                    foreach (Fornecedor c in fornecedores)
                    {
                        Console.WriteLine("===============================");
                        Console.WriteLine("Cnpj: " + c.Cnpj);
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("Cpf do Gerente: " + c.Cpf);
                        Console.WriteLine("===============================");
                    }

                }

            }
        }

    }
}
