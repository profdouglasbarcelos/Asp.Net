using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys.Models;

namespace WingtipToys
{
    public partial class ListaProdutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Produto> ObterProdutos([QueryString("id")] int? idCategoria)
        {
            var contexto = new ContextoProduto();
            IQueryable<Produto> lista;

            if (idCategoria.HasValue)
            {
                lista = contexto.Produtos.Where(p => p.CategoriaID == idCategoria);
            }
            else
            {
                lista = contexto.Produtos;
            }
            
            return lista;

            //return (IQueryable<Produto>)new ContextoProduto().Produtos;
        }
    }
}