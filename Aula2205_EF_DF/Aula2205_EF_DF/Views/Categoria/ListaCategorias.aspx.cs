using Aula2205_EF_DF.DAL;
using System;
using System.Linq;
using System.Web.UI;

namespace Aula2205_EF_DF.Views.Categoria
{
    public partial class ListaCategorias : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Contexto (referencia para o banco)
            strConnLojaEntities contexto = new strConnLojaEntities();

            gvwCategorias.DataSource = contexto.Categorias.ToList();
            gvwCategorias.DataBind();
        }

       
    }
}