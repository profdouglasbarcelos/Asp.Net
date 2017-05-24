using Aula2305_EF_DBF.Models;

namespace Aula2305_EF_DBF.Views.Base
{
    public class BasePage : System.Web.UI.Page
    {
        // contexto (referencia para o Banco de dados)
        protected LojaDBEntities contexto = new LojaDBEntities();
    }
}