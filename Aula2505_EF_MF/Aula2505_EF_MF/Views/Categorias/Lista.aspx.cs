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

        protected void gvCategorias_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Detectando a linha que foi clicada
            int linha = Convert.ToInt32(e.CommandArgument);

            // Recuperando o id do Objeto (lembrando que 2, do Cells[2], é a coluna onde esta o id)
            int idObjeto = Convert.ToInt32(gvCategorias.Rows[linha].Cells[2].Text);

            // Nome do comando para saber a acao
            string command = e.CommandName;

            // Proximos passos

            // adicionar id na Session

            if (command.Equals("Excluir"))
            {
                // Redirecionando para tela de exclusao
                Response.Redirect("Excluir.aspx");
            }
            else
            {
                if(command.Equals("Editar"))
                {
                    // Redirecionando para tela de edicao
                    Response.Redirect("Editar.aspx");
                }
            }
        }
    }
}