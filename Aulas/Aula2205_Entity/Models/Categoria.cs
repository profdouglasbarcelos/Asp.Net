using System.ComponentModel.DataAnnotations;

namespace Aula2205_Entity.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        [Required,StringLength(30)]
        public string Nome { get; set; }

        public bool Ativo { get; set; }

    }
}