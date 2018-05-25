using Aula2205_Entity.Models;
using Aula2205_Entity.Models.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Aula2205_Entity.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            MeuContexto contexto = new MeuContexto();
            List<Usuario> usuarios = contexto.Usuarios.ToList();

            return View(usuarios);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                MeuContexto contexto = new MeuContexto();
                contexto.Usuarios.Add(usuario);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        //GET
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MeuContexto contexto = new MeuContexto();

            Usuario usu = contexto.Usuarios.Find(id);

            if(usu == null)
            {
                return HttpNotFound();
            }

            return View(usu);
        }

        //GET
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MeuContexto contexto = new MeuContexto();

            Usuario usu = contexto.Usuarios.Find(id);

            if (usu == null)
            {
                return HttpNotFound();
            }

            return View(usu);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Usuario usu)
        {
            if(ModelState.IsValid)
            {
                MeuContexto contexto = new MeuContexto();

                contexto.Entry(usu).State = 
                    System.Data.Entity.EntityState.Modified;

                contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usu);
        }

        //GET
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MeuContexto contexto = new MeuContexto();

            Usuario usu = contexto.Usuarios.Find(id);

            if (usu == null)
            {
                return HttpNotFound();
            }

            return View(usu);
        }


        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MeuContexto contexto = new MeuContexto();
            Usuario usu = contexto.Usuarios.Find(id);

            contexto.Usuarios.Remove(usu);
            contexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}