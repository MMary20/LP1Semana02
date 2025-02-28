using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            double area_superficie = 2 * Math.PI * raio * (raio + altura);

            Console.WriteLine($"Volume: {volume}");
            Console.WriteLine($"Área da superfície: {area_superficie}");
        }
    }
}

