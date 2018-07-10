using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MelhorPreco.Models
{
    public class PRODUTO
    {
        public long PRODUTO_EAN { get; set; }
        public string PRODUTO_DESCRICAO { get; set; }
        public Nullable<long> PRODUTO_IMAGEM { get; set; }
        public string PRODUTO_CATEGORIA { get; set; }
        public string PRODUTO_SUBCATEGORIA { get; set; }
    }
}