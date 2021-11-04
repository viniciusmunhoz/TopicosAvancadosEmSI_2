using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendaCalcados.Models
{
    public class Venda
    {
        public int Id { get; set; }

        [DisplayName("Descrição")] // DisplayName para aparecer com a acentuação
        public string Descricao { get; set; }

        [DisplayName("Calçado")] // DisplayName para aparecer com a acentuação

        [NotMapped]
        public virtual Calcado Calcado { get; set; }

        public string Itens { get; set; }

        [NotMapped]
        public virtual List<SelectListItem> Calcados { get; set; }

        public virtual Cliente Cliente { get; set; }
        [NotMapped]
        public virtual List<SelectListItem> Clientes { get; set; }

        public float Total { get; set; }

        public DateTime DataVenda { get; set; }

        public Vendedor Vendedor { get; set; }

        [NotMapped]
        public virtual List<SelectListItem> Vendedores { get; set; }

        public virtual Loja Loja { get; set; }

        [NotMapped]
        public virtual List<SelectListItem> Lojas { get; set; }
    }
}
