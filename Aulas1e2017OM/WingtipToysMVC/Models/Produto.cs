using System.ComponentModel.DataAnnotations;

namespace WingtipToysMVC.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }

        [Required, StringLength(20)]
        public string Nome { get; set; }

        [Display(Name ="Descrição"), DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        public string Imagem { get; set; }

        [Required, Display(Name ="Categoria")]
        public int CategoriaID { get; set; }

        [Display(Name = "Categoria")]
        public virtual Categoria _Categoria { get; set; }
    }
}