using Aula2505_EF_MF.Controllers;
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
            CategoriasController ctrl = new CategoriasController();

            gvCategorias.DataSource = ctrl.Listar();
            gvCategorias.DataBind();



            // ---- Gerando Alert JS

            // sem updatepanel
            //var ID = "Lista carregada com sucesso";
            //ClientScript.RegisterStartupScript(this.GetType(), "script", "alert('" + ID + "');", true);

            // com update panel
            //var ID2 = "Whatever the data is";
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('" + ID2 + "');", true);
        }
    }
}