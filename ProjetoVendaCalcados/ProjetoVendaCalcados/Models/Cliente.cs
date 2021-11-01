﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendaCalcados.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}
