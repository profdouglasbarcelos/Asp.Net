namespace RelatoriosMVC.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public bool Ativo { get; set; }

        // relacionamento (Categoria)
        public int CategoriaID { get; set; }

        public virtual Categoria _Categoria { get; set; }

    }
}