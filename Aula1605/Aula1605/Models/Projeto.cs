using System.ComponentModel.DataAnnotations;

namespace Aula1605.Models
{
    public class Projeto
    {
        [Key]
        public int ProjetoID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public bool Ativo { get; set; }
    }
}