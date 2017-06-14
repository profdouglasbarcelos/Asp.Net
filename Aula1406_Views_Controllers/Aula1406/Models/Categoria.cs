using System.ComponentModel.DataAnnotations;

namespace Aula1406.Models
{
    public class Categoria
    {
        [Key, ScaffoldColumn(false)]
        public int CategoriaID { get; set; }

        [Required(ErrorMessage ="Favor preencher o campo nome!")]
        [StringLength(10, ErrorMessage ="Não pode exceder o tamanho de 10 caracteres")]
        public string Nome { get; set; }

        [Display(Name ="Descrição"), DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Required]
        public bool Ativo { get; set; }

    }
}