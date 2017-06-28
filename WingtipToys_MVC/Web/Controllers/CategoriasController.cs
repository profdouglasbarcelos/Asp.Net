using System.Web.Mvc;
using Web.Models;
using System.Linq;
using BaseModels;
using System.Net;

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

        //  --------- Cadastrar nova Categoria ------------
        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            if(ModelState.IsValid)
            {
                db.Categorias.Add(categoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoria);
        }


        // --------- Detalhes --------
        // GET
        public ActionResult Details(int? id)
        {
            // Nao passou id?
            if(id == null /*id.HasValue*/)
            {
                // ERRO HTTP 400
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categoria categoria = db.Categorias.Find(id);

            // nao encontrou o objeto com este id
            if(categoria == null)
            {
                // ERRO HTTP 404
                return HttpNotFound();
            }

            // caso a categoria seja encontrada, retorna ela para a view
            return View(categoria);
        }


        // ------------ Editar -------------
        // GET
        public ActionResult Edit(int? id)
        {
            // Nao passou id?
            if (id == null /*id.HasValue*/)
            {
                // ERRO HTTP 400
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categoria categoria = db.Categorias.Find(id);

            // nao encontrou o objeto com este id
            if (categoria == null)
            {
                // ERRO HTTP 404
                return HttpNotFound();
            }

            // caso a categoria seja encontrada, retorna ela para a view
            return View(categoria);
        }

        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            if(ModelState.IsValid)
            {
                db.Entry(categoria).State = 
                    System.Data.Entity.EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        // ------------- Excluir ------------


        // GET
        public ActionResult Delete(int? id)
        {
            // Nao passou id?
            if (id == null /*id.HasValue*/)
            {
                // ERRO HTTP 400
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categoria categoria = db.Categorias.Find(id);

            // nao encontrou o objeto com este id
            if (categoria == null)
            {
                // ERRO HTTP 404
                return HttpNotFound();
            }

            // caso a categoria seja encontrada, retorna ela para a view
            return View(categoria);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Categoria categoria = db.Categorias.Find(id);

            db.Categorias.Remove(categoria);

            //db.Entry(categoria).State = 
            //    System.Data.Entity.EntityState.Deleted;

            db.SaveChanges();

            return RedirectToAction("Index");
        }


        

    }
}