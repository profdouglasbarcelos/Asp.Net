using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Produto
    {
        [Key]
        public int ProdutoID { get; set; }

        [Required]
        [StringLength(20)]
        public string Nome { get; set; }
      
        public string Descricao { get; set; }

        [Required]
        public bool Ativo { get; set; }



        // -- Relacionamento Categoria --> Produto

        public int CategoriaID { get; set; }
        
        public virtual Categoria _Categoria { get; set; }
    }
}
