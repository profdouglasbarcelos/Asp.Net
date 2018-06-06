using System.Web;
using System.Web.Mvc;

namespace Aula0506_Autenticacao
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
