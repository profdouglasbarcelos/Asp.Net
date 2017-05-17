using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace WingtipToys.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}