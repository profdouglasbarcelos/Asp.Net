using System.Web.Mvc;
using Web.Models;
using System.Linq;

namespace Web.Controllers
{
    public class CategoriasController : Controller
    {
        // Contexto do banco de dados
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Categorias (listagem)
        public ActionResult Index()
        {
            var categorias = db.Categorias.ToList();
            return View(categorias);
        }
    }
}