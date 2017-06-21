using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public bool Ativo { get; set; }

    }
}
