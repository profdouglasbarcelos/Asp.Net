namespace CadastroEntidadesRelacionadas.Models
{
    public class EntidadeA
    {
        public int EntidadeAID { get; set; }

        public string Nome { get; set; }

        public int? EntidadeBID { get; set; }

        public virtual EntidadeB _EntidadeB { get; set; }

    }
}