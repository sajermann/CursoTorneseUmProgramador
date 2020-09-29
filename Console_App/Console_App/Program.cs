using Tela;
using System;
using System.Collections.Generic;
using System.IO;
using Classes;
using Componentes;

namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu.Criar();
            Console.WriteLine("=============Cadastro de Cliente====================");
            Cliente c = new Cliente();
            c.Nome = "Cliente";
            c.Telefone = "23223";
            c.Cpf = "2156151515";
            c.Gravar();

            foreach (Cliente cl in new Cliente().Ler())
            {
                Console.WriteLine(cl.Nome);
                Console.WriteLine(cl.Telefone);
                Console.WriteLine(cl.Cpf);
                Console.WriteLine("=================================");
            }

            Console.WriteLine("=============Cadastro de Usuário====================");
            Usuario u = new Usuario();
            u.Nome = "Usuário";
            u.Telefone = "1199959595";
            u.Cpf = "2156151515";
            u.Gravar();
            
            foreach (Usuario us in new Usuario().Ler())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.Cpf);
                Console.WriteLine("=================================");
            }
        }
    }
}
