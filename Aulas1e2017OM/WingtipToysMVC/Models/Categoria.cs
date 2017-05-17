using System.ComponentModel.DataAnnotations;

namespace WingtipToysMVC.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Display(Name ="Descrição"), DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
    }
}