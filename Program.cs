using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            string entradaF;
            double f;
            double c;
            double resultado;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Digite uma temperatura em °F");
            Console.WriteLine("---------------------");
            Console.Write("°F:");
            entradaF = Console.ReadLine();

            f = Convert.ToDouble(entradaF);
            c = f - 32;
            resultado = c / 1.8;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n{f}°F equivalem a {resultado:N3}°C");
            Console.ResetColor();





        }
    }
}
