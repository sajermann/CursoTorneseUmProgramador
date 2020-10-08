using System;
using System.Collections.Generic;
using System.Net;

namespace Business
{
    public class Cliente
    {
        public string Nome { get; set; }
        public List<Cliente> Clientes(string cliente)
        {
            //new Database.Cliente().Clientes
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Nome = "Bruno" });
            return clientes;
        }
    }
}
