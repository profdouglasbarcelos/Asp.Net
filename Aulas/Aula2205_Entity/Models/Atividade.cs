using System.ComponentModel.DataAnnotations;

namespace Aula2205_Entity.Models
{
    public class Atividade
    {

        public int AtividadeID { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public int CategoriaID { get; set; }

        public virtual Categoria _Categoria { get; set; }

        public int UsuarioID { get; set; }

        public virtual Usuario _Usuario { get; set; }


    }
}