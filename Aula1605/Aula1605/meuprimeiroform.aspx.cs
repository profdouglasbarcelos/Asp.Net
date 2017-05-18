using Aula1605.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1605
{
    public partial class meuprimeiroform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtnome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            chkAtivo.Checked = false;
            
            
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Projeto proj = new Projeto();
            proj.Nome = txtnome.Text;
            proj.Ativo = chkAtivo.Checked;
            proj.Descricao = txtDescricao.Text;

        }
    }
}