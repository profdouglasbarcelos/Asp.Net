using Aula2505_EF_MF.Models;
using System.Collections.Generic;
using System.Linq;

namespace Aula2505_EF_MF.Controllers
{
    public class CategoriasController
    {
      private BaseDadosContainer contexto = new BaseDadosContainer();

        public void Adicionar(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        public List<Categoria> Listar()
        {
            return contexto.Categorias.ToList();
        }

        public Categoria LocalizarPorID(int id)
        {
            return contexto.Categorias.Find(id);
        }

        public void Editar(Categoria categoria)
        {
            contexto.Entry(categoria).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public void Excluir(Categoria categoria)
        {
            contexto.Entry(categoria).State =
                System.Data.Entity.EntityState.Deleted;

            contexto.SaveChanges();
        }

    }
}