using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CadastroEntidadesRelacionadas.Models;

namespace CadastroEntidadesRelacionadas.Controllers
{
    public class EntidadeBsController : Controller
    {
        private CadastroEntidadesRelacionadasContext db = new CadastroEntidadesRelacionadasContext();

        // GET: EntidadeBs
        public ActionResult Index()
        {
            return View(db.EntidadeBs.ToList());
        }

        // GET: EntidadeBs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntidadeB entidadeB = db.EntidadeBs.Find(id);
            if (entidadeB == null)
            {
                return HttpNotFound();
            }
            return View(entidadeB);
        }

        // GET: EntidadeBs/Create
        public ActionResult Create(int EntidadeAID)
        {
            TempData["EntidadeAID"] = EntidadeAID;
            return View();
        }

        // POST: EntidadeBs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EntidadeBID,Endereco")] EntidadeB entidadeB)
        {
            if (ModelState.IsValid)
            {
                db.EntidadeBs.Add(entidadeB);
                db.SaveChanges();

                int entidadeAID = int.Parse(TempData["EntidadeAID"].ToString());
                TempData.Remove("EntidadeAID");

                EntidadeA ea = db.EntidadeAs.Find(entidadeAID);

                ea.EntidadeBID = entidadeB.EntidadeBID;
                db.Entry(ea).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(entidadeB);
        }

        // GET: EntidadeBs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntidadeB entidadeB = db.EntidadeBs.Find(id);
            if (entidadeB == null)
            {
                return HttpNotFound();
            }
            return View(entidadeB);
        }

        // POST: EntidadeBs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EntidadeBID,Endereco")] EntidadeB entidadeB)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entidadeB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entidadeB);
        }

        // GET: EntidadeBs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntidadeB entidadeB = db.EntidadeBs.Find(id);
            if (entidadeB == null)
            {
                return HttpNotFound();
            }
            return View(entidadeB);
        }

        // POST: EntidadeBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EntidadeB entidadeB = db.EntidadeBs.Find(id);
            db.EntidadeBs.Remove(entidadeB);
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
