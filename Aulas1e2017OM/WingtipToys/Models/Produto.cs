using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WingtipToys.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string CaminhoImagem { get; set; }

        public double? ValorUnitario { get; set; }

        public int CategoriaID { get; set; }

        public virtual Categoria _Categoria { get; set; }
    }
}