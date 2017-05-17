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
    public partial class DetalhesProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Produto> ObterProduto([QueryString("idProduto")] int? idProduto)
        {
            if(!idProduto.HasValue || idProduto.Value == 0)
            {
                return null; // ERRO http 400 Response.Redirect("/Error");
            }

            ContextoProduto ctx = new ContextoProduto();
            return ctx.Produtos.Where(p => p.ProdutoID == idProduto);
        }
    }
}