using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjVendaCalcados.Models
{
    public class Venda
    {
        public int Id { get; set; }

        [DisplayName("Descrição")] // DisplayName para aparecer com a acentuação
        public string Descricao { get; set; }

        [DisplayName("Calçado")] // DisplayName para aparecer com a acentuação
        public virtual Calcado Calcado { get; set; }

        public virtual Cliente Cliente { get; set; }

        public DateTime DataVenda { get; set; }

        public Vendedor Vendedor { get; set; }

        public virtual Loja Loja { get; set; }

    }
}
