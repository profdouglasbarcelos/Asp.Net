using Aula1406.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Aula1406.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias (GET = carregamento da pagina)
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();

            // Retornar a lista de objetos cadastrados
            return View(categorias);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        /*public ActionResult Create(string nome, string descricao, bool ativo)*/
        /*public ActionResult Create(FormCollection campos) recuperar campo a campo, sem ter model*/
        public ActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                // insert
            }

            return View(categoria);
        }


        // GET
        public ActionResult Edit(int? id)
        {
            // verificar se nao veio id => BadRequest
            if (id == null)
            {
                // Erro - 400
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // Pesquisa na fonte de dados o objeto a editar
            //Categoria categoria = null;
            Categoria categoria = 
                new Categoria()
                {
                    CategoriaID = id.Value,
                    Nome = "Carros",
                    Descricao = "Super carros",
                    Ativo = true
                };

            // se objeto nao foi encontrado na fonte de dados
            if (categoria == null)
            {
                // Erro - 404
                return HttpNotFound();
            }


            return View(categoria);
        }

        // POST
        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // fazer update na fonte de dados
                    // Redirecionar
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return View(categoria);
        }


        // GET
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categoria categoria =
                new Categoria()
                {
                    CategoriaID = id.Value,
                    Nome = "Carros",
                    Descricao = "Super carros",
                    Ativo = true
                };

            if (categoria == null)
            {
                return HttpNotFound();
            }

            return View(categoria);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            // pesquisar objeto por id

            // alterar status do objeto para deleted ou ativo para false

            TempData["Mensagem"] = "Categoria excluida com sucesso";
            return RedirectToAction("Index");
        }
    }
}