using Aula2405_EF_MF.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula2405_EF_MF.Views.Categorias
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Categoria> categorias = contexto.Categorias.ToList();
        }
    }
}