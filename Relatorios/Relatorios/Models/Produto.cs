using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relatorios.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }

        [Required]
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        // Relacionamento

        [ForeignKey("_Categoria")]
        public int CategoriaID { get; set; }

        //[ForeignKey("CategoriaID")]
        public virtual Categoria _Categoria { get; set; }

    }
}