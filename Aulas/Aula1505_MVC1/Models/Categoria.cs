using System.ComponentModel.DataAnnotations;

namespace Aula1505_MVC1.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        [Display(Name ="Título")]
        [Required(ErrorMessage ="Favor preencher o campo Título.")]
        public string Nome { get; set; }

        public bool Ativo { get; set; }

    }
}