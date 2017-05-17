using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys.Models;

namespace WingtipToys
{
    public partial class EditarProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCategoria.DataValueField = "CategoriaID";
                ddlCategoria.DataTextField = "Nome";
                ddlCategoria.DataSource = new ContextoProduto().Categorias.ToList();
                ddlCategoria.DataBind();
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            //ContextoProduto contexto = new ContextoProduto();

            using (ContextoProduto contexto = new ContextoProduto())
            {
                Produto p = new Produto();

                p.Nome = txtNome.Text;
                p.Descricao = txtDescricao.Text;
                p.CategoriaID = Convert.ToInt32(ddlCategoria.SelectedValue);

                contexto.Produtos.Add(p);
                contexto.SaveChanges();
                Response.Redirect("/ListaProdutos.aspx");
            }
        }
    }
}