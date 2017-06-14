using System.ComponentModel.DataAnnotations;

namespace Aula1306.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        [Required(ErrorMessage ="Favor preencher o nome!")]
        public string Nome { get; set; }

        [Display(Name ="Descrição"), DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        public bool Ativo { get; set; }

    }
}