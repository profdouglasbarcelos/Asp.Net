using Aula2305_EF_DBF.Models;
using Aula2305_EF_DBF.Views.Base;
using System;
using System.Linq;

namespace Aula2305_EF_DBF.Views.Categoria
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvCategorias.DataSource = 
                contexto.Categoria.ToList();

            gvCategorias.DataBind();
        }
    }
}