using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjMVC30082021.Models
{
    public class Padaria
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public int QtdFuncionarios { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

    }
}
