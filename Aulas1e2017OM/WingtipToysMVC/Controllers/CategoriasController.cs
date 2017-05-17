using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WingtipToysMVC.Models;

namespace WingtipToysMVC.Controllers
{
    public class CategoriasController : Controller
    {
        private WingtipToysMVCContext banco = new WingtipToysMVCContext();

        public JsonResult AutoCompleteNome(string prefixo)
        {
            var categorias = banco.Categorias.Where(c => c.Nome.Contains(prefixo));
            return Json(categorias, JsonRequestBehavior.AllowGet);
        }

        // GET: Categorias  (www.meusistema.com/Categorias)
        public ActionResult Index(string filtroNome)
        {
            IQueryable<Categoria> categorias = banco.Categorias;

            if (!string.IsNullOrEmpty(filtroNome))
            {
                filtroNome = filtroNome.ToLower();
                categorias = categorias.Where(c => c.Nome.ToLower().Contains(filtroNome));
            }

            return View(categorias.ToList());
        }

        //GET: Categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            if(ModelState.IsValid)
            {
                banco.Categorias.Add(categoria);
                banco.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoria);
        }


        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categoria categoria = banco.Categorias.Find(id);

            if(categoria == null)
            {
                return HttpNotFound();
            }

            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria categoria)
        {
            if(ModelState.IsValid)
            {
                banco.Entry(categoria).State = EntityState.Modified;
                banco.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categoria cat = banco.Categorias.Find(id);

            if(cat == null)
            {
                return HttpNotFound();
            }

            return View(cat);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ExclusaoConfirmada(int id)
        {
            Categoria cat = banco.Categorias.Find(id);
            banco.Categorias.Remove(cat);
            banco.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}