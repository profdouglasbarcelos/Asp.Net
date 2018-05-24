using Aula2205_Entity.Models;
using Aula2205_Entity.Models.DAL;
using System.Collections.Generic;
using System.Linq;
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



    }
}