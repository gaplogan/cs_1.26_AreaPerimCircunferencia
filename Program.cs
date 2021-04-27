using System;

namespace cs_1._26_AreaPerimCircunferencia
{    
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area, perim;

            Console.Write("Digite o valor do raio do círculo: ");
            raio = double.Parse(Console.ReadLine());
            // Garante um raio não negativo.
            raio = Math.Abs(raio);

            area = Math.PI * Math.Sqrt(raio);
            perim = 2 * Math.PI * raio;

            Console.WriteLine($"\nÁrea do círculo: {area}");
            Console.WriteLine($"Perímetro da circunferência: {perim}");
        }
    }
}
