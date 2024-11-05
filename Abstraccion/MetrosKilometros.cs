

namespace Abstraccion
{
    public class MetrosKilometros
    {
        public override double Calcular()
        {
            return metros / 1000;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{metros} metros equivalen a {Calcular()} kilómetros.");
        }
    }
}
