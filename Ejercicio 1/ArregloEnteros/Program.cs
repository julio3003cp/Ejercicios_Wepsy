using System;

namespace ArregloEnteros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Init");

            int[] prueba1 = new int[7] { 8, 6, 4, 5, 6, 9, 2 };
            int minimo, maximo;
            decimal promedio;

            Rangos calcular = new Rangos(prueba1);

            minimo = calcular.GetMinimo();
            maximo = calcular.GetMaximo();
            promedio = calcular.GetPromedio();

            Console.WriteLine($"El minimo es {minimo}");
            Console.WriteLine($"El maximo es {maximo}");
            Console.WriteLine($"El maximo es {promedio}");

            Console.WriteLine("Fin");
            Console.ReadKey();

        }
    }
}
