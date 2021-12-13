using System;

namespace TransformacionString
{
    class Program
    {
        static void Main(string[] args)
        {

            var handler = new StringHandler();

            Console.WriteLine("Introduce el string a formatear");
            string input = Console.ReadLine();

            Console.WriteLine("Introduce el transformator");
            string transformation = Console.ReadLine();

            string result = handler.Transform(input, transformation);

            Console.WriteLine($"El resultado es {result}");

            Console.ReadKey();
        }
    }
}
