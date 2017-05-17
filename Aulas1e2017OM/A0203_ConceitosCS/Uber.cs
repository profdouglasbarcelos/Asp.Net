namespace A0203_ConceitosCS
{
    public class Uber : Carro
    {
        public string NomeMotorista { get; set; }

        public Uber(string nomeMotorista)
        {
            NomeMotorista = nomeMotorista;
        }
    }
}
