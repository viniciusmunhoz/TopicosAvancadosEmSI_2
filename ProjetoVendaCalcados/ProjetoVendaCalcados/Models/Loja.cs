using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendaCalcados.Models
{
    public class Loja
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cnpj { get; set; }
    }
}
