using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendaCalcados.Models
{
    public class Calcado
    {
        public int Id { get; set; }

        [DisplayName("Calçado")] // DisplayName para aparecer com a acentuação
        public string NomeCalcado { get; set; }
        public string Tipo { get; set; }
        public short Numero { get; set; }

        [DisplayName("Preço")] // DisplayName para aparecer com a acentuação
        public float Preco { get; set; }

        [DisplayName("Imagem")]
        public string Imagem { get; set; }

        [NotMapped]
        [DisplayName("Imagem do Calcado")]
        public IFormFile ImagemCalcado { get; set; }
    }
}
