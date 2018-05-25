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
    }
}