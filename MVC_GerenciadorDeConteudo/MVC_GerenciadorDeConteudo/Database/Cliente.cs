﻿using System;
using System.Collections.Generic;

namespace Database
{
    public class Cliente
    {
        public string Nome { get; set; }
        public List<Cliente> Clientes(string cliente)
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Nome = "Bruno" });
            return clientes;
        }
    }
}
