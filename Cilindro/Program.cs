using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Altura do cilindro: ");
            string alturaCilindro = Console.ReadLine();

            Console.Write("Raio do cilindro: ");
            string raioCilindro = Console.ReadLine();

            int a = int.Parse(alturaCilindro);
            int r = int.Parse(raioCilindro);

            double v = MathF.PI*MathF.Pow(r,2)*a;
            Console.WriteLine($"Volume do cilindro: {v:f3}");

            double Sa = 2*MathF.PI*r*(r+a);
            Console.WriteLine($"Área da superfície do cilindro: {Sa:f3}");
        }
    }
}