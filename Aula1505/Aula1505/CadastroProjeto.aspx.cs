using Aula1505.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1505
{
    public partial class CadastroProjeto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            chkAtivo.Checked = false;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Projeto prj = new Projeto();
            prj.Nome = txtNome.Text;
            prj.Descricao = txtDescricao.Text;
            prj.Ativo = chkAtivo.Checked;


        }
    }
}