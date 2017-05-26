using Aula2505_EF_MF.Models;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2505_EF_MF.Views.Categorias
{
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BaseDadosContainer contexto = new BaseDadosContainer();

            var categorias = contexto.Categorias;

            gvCategorias.DataSource = categorias.ToList();
            gvCategorias.DataBind();

            // sem updatepanel
            var ID = "Whatever the data is";
            ClientScript.RegisterStartupScript(this.GetType(), "script", "alert('" + ID + "');", true);

            // com update panel
            //var ID2 = "Whatever the data is";
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('" + ID2 + "');", true);
        }
    }
}