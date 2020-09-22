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
            var clientes = Cliente.LerClientes();
            
            var cliente = new Cliente();
            cliente.Nome = "Bruno";
            cliente.Telefone = "11254841541515";
            cliente.Cpf = "65656565656565";
            cliente.Gravar();


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
