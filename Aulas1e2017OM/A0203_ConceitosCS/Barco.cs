using System;

namespace A0203_ConceitosCS
{
    public class Barco : MeioTransporte
    {
        public int QuantidadePes { get; set; }

        public override void Acelerar()
        {
            throw new NotImplementedException();
        }

        public override void Frear()
        {
            throw new NotImplementedException();
        }
    }
}
