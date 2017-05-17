namespace A0203_ConceitosCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            c.Ano = 1980;
            c.QuantidadeRoda = 4;
            c.Nome = "Fusca";

            c.Acelerar();
            c.Frear();

            Barco b = new Barco();
            b.QuantidadePes = 20;
            b.Nome = "Titanic";
            b.Ano = 1909;

            b.Acelerar();
            b.Frear();

            Uber u = new Uber("Godofredo");
            u.Ano = 2017;
            u.Nome = "BMW";
            u.QuantidadeRoda = 4;

            u.Acelerar();
            u.Frear();

            //MeioTransporte mt = new MeioTransporte();
            //mt.Nome = "MeioTransporte";
            System.Console.ReadKey();
        }
    }
}
