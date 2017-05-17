using System;

namespace A0203_ConceitosCS
{
    public class Carro : MeioTransporte
    {
        public override void Acelerar()
        {
            //base.Acelerar();
            System.Console.WriteLine("Carro: Acelerando...");
        }

        public override void Frear()
        {
            System.Console.WriteLine("Carro: Freando...");
        }
    }
}
