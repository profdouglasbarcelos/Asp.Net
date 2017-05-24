using Aula2305_EF_DBF.Models;
using Aula2305_EF_DBF.Views.Base;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace Aula2305_EF_DBF.Views.Produto
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var produtosCadastrados = contexto.Produto;

            gvProdutos.DataSource = produtosCadastrados.ToList();
            gvProdutos.DataBind();
        }
    }
}