using Aula2405_EF_MF.Controllers;
using Aula2405_EF_MF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2405_EF_MF.Views.Categorias
{
    public partial class Criar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();

            cat.Nome = txtNome.Text;
            cat.Descricao = txtDescricao.Text;
            cat.Ativo = true;

            CategoriasController ctrl = new CategoriasController();

            ctrl.Adicionar(cat);
        }
    }
}