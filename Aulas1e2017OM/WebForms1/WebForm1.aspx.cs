using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblConvidado.Text = "Usuário anônimo";
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            lblConvidado.Text = "Seja bem vindo " + txtNome.Text;
        }
    }
}