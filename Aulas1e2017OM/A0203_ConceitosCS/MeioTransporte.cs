using System;

namespace A0203_ConceitosCS
{
    public abstract class MeioTransporte : IMotorizado
    {
        public int QuantidadeRoda { get; set; }

        public string Nome { get; set; }

        public int Ano { get; set; }

        public abstract void Acelerar();
        public abstract void Frear();
    }
}
