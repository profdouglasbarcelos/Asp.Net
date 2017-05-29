using Aula2405_EF_MF.Models;
using System.Collections.Generic;
using System.Linq;

namespace Aula2405_EF_MF.Controllers
{
    public class CategoriasController
    {
        protected BaseDadosContainer contexto = new BaseDadosContainer();

        public void Adicionar(Categoria categoria)
        {
            if(categoria != null)
            {
                contexto.Categorias.Add(categoria);
                contexto.SaveChanges();
            }
        }

        public List<Categoria> Listar()
        {
            return contexto.Categorias.ToList();
        }

        public Categoria BuscarCategoriaPorID(int id)
        {
            return contexto.Categorias.Find(id);
        }

        public void Excluir(Categoria categoria)
        {
            contexto.Entry(categoria).State = 
                System.Data.Entity.EntityState.Deleted;

            contexto.SaveChanges();
        }

        public void Editar(Categoria categoria)
        {
            contexto.Entry(categoria).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }
    }
}