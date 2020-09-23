using Tela;
using System;
using System.Collections.Generic;
using System.IO;
using Classes;

namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu.Criar();


            Cliente.Teste = "sss";
            
            var cliente = new Cliente("Bruno");
            cliente.Nome = "Jhonson";
            cliente.Telefone = "11254841541515";
            cliente.Cpf = "65656565656565";
            cliente.Gravar();

            // Cliente c = new Cliente();

            // Cliente c2 = new Cliente { Nome = "Bruno", Telefone = "1515151", Cpf = "62626262" };
            var clientes = Cliente.LerClientes();
            foreach (Cliente c in clientes)
            {
                Console.WriteLine(c.Nome);
                Console.WriteLine(c.Telefone);
                Console.WriteLine(c.Cpf);
                Console.WriteLine("===============================");
            }

            Console.ReadLine();
            
            /*
            var cliente2 = new Cliente();
            cliente2.Nome = "Márcia";
            cliente2.Telefone = "62662626262";
            cliente2.Cpf = "54541851515";
            cliente2.Gravar();
            */
        
        }
    }
}
