using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjMVC30082021.Models
{
    public class Produto
    {
        public int id { get; set; }

        public string Descricao { get; set; }

        public DateTime Validade { get; set; }
    }
}
