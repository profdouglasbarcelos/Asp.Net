using System;

namespace A0203_ConceitosCS
{
    public class Onibus : IMotorizado
    {
        void IMotorizado.Acelerar()
        {
            Console.WriteLine("Acelerando lentamente...");
        }

        void IMotorizado.Frear()
        {
            Console.WriteLine("Freando lentamente...");
        }
    }
}
