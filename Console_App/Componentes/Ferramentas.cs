﻿using System;

namespace Componentes
{
    public class Ferramentas
    {
        internal string MetodoSomenteParaMeuAssembly()
        {
            return "Este método só pode ser acessado dentro deste assembly componentes";
        }
        public string MetodoSomenteParaTodosQueUtilizarOAssembly()
        {
            return "Este método é para todos";
        }

        public bool ValidarCpf(string cpf)
        {
            return true;
        }


    }
}
