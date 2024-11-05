

namespace Abstraccion
{
    public class OnzasKilogramos
    {
        private double onzas;

        public OnzasKilogramos(double onzas)
        {
            this.onzas = onzas;
        }

        public override double Calcular()
        {
            return onzas * 0.0283495; // Factor de conversión
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{onzas} onzas equivalen a {Calcular()} kilogramos.");
        }
    }
}
