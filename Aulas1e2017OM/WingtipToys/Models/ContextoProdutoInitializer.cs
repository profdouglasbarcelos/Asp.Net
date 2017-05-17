using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WingtipToys.Models
{
  //public class ContextoProdutoInitializer : DropCreateDatabaseAlways<ContextoProduto>
    public class ContextoProdutoInitializer : DropCreateDatabaseIfModelChanges<ContextoProduto>
    {
        protected override void Seed(ContextoProduto context)
        {
            //base.Seed(context);
            CriarCategorias(context);
            CriarProdutos(context);

            context.SaveChanges();
        }

        private void CriarProdutos(ContextoProduto contexto)
        {
            var listaProdutos = new List<Produto>();

            listaProdutos.Add(
                    new Produto
                    {
                        Nome = "Fusca",
                        Descricao = "Carro Clássico",
                        CaminhoImagem = "fusca.jpg",
                        ValorUnitario = 60,
                        CategoriaID = 1
                    }
                );

            listaProdutos.Add(
                    new Produto
                    {
                        Nome = "Fusion",
                        Descricao = "Carro sedan",
                        CaminhoImagem = "fusion.jpg",
                        ValorUnitario = 10,
                        CategoriaID = 1
                    }
                );

            listaProdutos.Add(
                    new Produto
                    {
                        Nome = "Titanic",
                        Descricao = "Barco Clássico",
                        CaminhoImagem = "titanic.jpg",
                        ValorUnitario = 600,
                        CategoriaID = 2
                    }
                );

            contexto.Produtos.AddRange(listaProdutos);
        }

        private void CriarCategorias(ContextoProduto contexto)
        {
            var listaCategoria = new List<Categoria>();

            listaCategoria.Add(
                new Categoria { Nome = "Carros" }
                );

            listaCategoria.Add(
                new Categoria { Nome = "Barcos" }
                );

            listaCategoria.Add(
                new Categoria { Nome = "Aviões" }
                );

            contexto.Categorias.AddRange(listaCategoria);
        }
    }
}