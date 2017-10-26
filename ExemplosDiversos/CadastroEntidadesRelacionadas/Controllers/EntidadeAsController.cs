using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CadastroEntidadesRelacionadas.Models;

namespace CadastroEntidadesRelacionadas.Controllers
{
    public class EntidadeAsController : Controller
    {
        private CadastroEntidadesRelacionadasContext db = new CadastroEntidadesRelacionadasContext();

        // GET: EntidadeAs
        public ActionResult Index()
        {
            var entidadeAs = db.EntidadeAs.Include(e => e._EntidadeB);
            return View(entidadeAs.ToList());
        }

        // GET: EntidadeAs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntidadeA entidadeA = db.EntidadeAs.Find(id);
            if (entidadeA == null)
            {
                return HttpNotFound();
            }
            return View(entidadeA);
        }

        // GET: EntidadeAs/Create
        public ActionResult Create()
        {
            ViewBag.EntidadeBID = new SelectList(db.EntidadeBs, "EntidadeBID", "Endereco");
            return View();
        }

        // POST: EntidadeAs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EntidadeAID,Nome,EntidadeBID")] EntidadeA entidadeA)
        {
            if (ModelState.IsValid)
            {
                db.EntidadeAs.Add(entidadeA);
                db.SaveChanges();
                //return RedirectToAction("Index");
                return RedirectToAction("Create", "EntidadeBs", new { EntidadeAID = entidadeA.EntidadeAID });
            }

            ViewBag.EntidadeBID = new SelectList(db.EntidadeBs, "EntidadeBID", "Endereco", entidadeA.EntidadeBID);
            return View(entidadeA);
        }

        // GET: EntidadeAs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntidadeA entidadeA = db.EntidadeAs.Find(id);
            if (entidadeA == null)
            {
                return HttpNotFound();
            }
            ViewBag.EntidadeBID = new SelectList(db.EntidadeBs, "EntidadeBID", "Endereco", entidadeA.EntidadeBID);
            return View(entidadeA);
        }

        // POST: EntidadeAs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EntidadeAID,Nome,EntidadeBID")] EntidadeA entidadeA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entidadeA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EntidadeBID = new SelectList(db.EntidadeBs, "EntidadeBID", "Endereco", entidadeA.EntidadeBID);
            return View(entidadeA);
        }

        // GET: EntidadeAs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntidadeA entidadeA = db.EntidadeAs.Find(id);
            if (entidadeA == null)
            {
                return HttpNotFound();
            }
            return View(entidadeA);
        }

        // POST: EntidadeAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EntidadeA entidadeA = db.EntidadeAs.Find(id);
            db.EntidadeAs.Remove(entidadeA);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
