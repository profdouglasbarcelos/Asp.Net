

using System.ComponentModel.DataAnnotations;

namespace Aula1505.Models
{
    public class Projeto
    {
        [Key]
        public int ProjetoID { get; set; }

        [Required,StringLength(20)]
        public string Nome { get; set; }

        [Display(Name ="Descrição"), DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        public bool Ativo { get; set; }
    }
}