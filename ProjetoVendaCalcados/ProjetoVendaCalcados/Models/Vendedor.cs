using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendaCalcados.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string NomeVendedor { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        [DisplayName("Cpf")]
        public string Cnpj { get; set; }
    }
}
